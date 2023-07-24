using Microsoft.Data.SqlClient.Server;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Microsoft.VisualBasic;
using PetStore_Repository_PhamNgocHieu.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PetStore_Repository_PhamNgocHieu.Dao;

public class PetDbContext:PetShop2023DBContext
{
    private static PetDbContext instance = null;
    private static readonly object instanceLock = new object();
    private PetDbContext()
    {

    }
    public static PetDbContext Instance
    {
        get
        {
            lock (instanceLock)
            {
                if (instance == null)
                {
                    instance = new PetDbContext();
                }
                return instance;
            }
        }
    }
    //return 1 member by Id
    public Pet GetPetById(int id)
    {
        return this.Pets.FirstOrDefault(m => m.PetId.Equals(id));

    }
    public IEnumerable<Pet> GetAllPets()
    {
        //var pets = this.Pets.ToList();
        return this.Pets.ToList();
    }
    public void UpdatePet(Pet pet)
    {
        this.Pets.Update(pet);
        this.SaveChanges();
    }
    public void DeletePet(int id)
    {
        var pet = this.Pets.FirstOrDefault(p=>p.PetId==id);
        if (pet != null)
        {
            this.Pets.Remove(pet);
            this.SaveChanges();
        }
    }
    public void AddPet(Pet pet)
    {
        this.Pets.Add(pet);
        this.SaveChanges();
    }

    public IEnumerable<Pet> SearchPetsByQuantity(string quantity)
    {
        return this.Pets.ToList().Where(p => p.Quantity.ToString().Contains(quantity));
    }

    public IEnumerable<Pet> SearchPetsByPrice(String price)
    {
        return this.Pets.ToList().Where(p => ((decimal)p.PetPrice).ToString().Contains(price));
    }

    public IEnumerable<PetGroup> GetPetGroups()
    {
        return this.PetGroups.ToList();
    }
}
