using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PracticalTest.model;
using PracticalTest.service;

namespace PracticalTest.Controller
{
    public class ContactController
    {
        private IContactService contactService;
        public ContactController(IContactService IContactService){
            contactService = IContactService;
        }

        public void addContact(Contact contact)
        {
            contactService.AddContact(contact);
        }

        public void getAllContact(){
            contactService.getAllContact();
        }

        public void searchContactByName(String name)
        {
            contactService.searchContactByName(name);
        }

    }
}