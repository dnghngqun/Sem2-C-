using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PracticalTest.model;
namespace PracticalTest.service
{
    public interface IContactService
    {
        void AddContact(Contact contact);
        void searchContactByName(String Name);
        void getAllContact();

    }
}