using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using PracticalTest.model;

namespace PracticalTest.service
{
    public class ContactService : IContactService
    {
        private MySqlConnection conn;
        private Hashtable contacts;
        public ContactService(String connectionString){
            contacts = new Hashtable();
            conn = new MySqlConnection(connectionString);
        }
        public void AddContact(Contact contact)
        {
            try
            {
                contacts.Add(contact.PhoneNumber, contact.Name);
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO Contact (name, phoneNumber) VALUES (@name, @phoneNumber)";
                cmd.Parameters.AddWithValue("@name", contact.Name);
                cmd.Parameters.AddWithValue("@phoneNumber", contact.PhoneNumber);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Add contact to Database successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding contact: {ex.Message}");
            }
            finally
            {
                conn.Close();
            }
        }

        public void getAllContact()
        {
            try
            {
                contacts.Clear();
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "Select name, phoneNumber From Contact ;";
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string name = reader["name"].ToString();
                    string phoneNumber = reader["phoneNumber"].ToString();
                    contacts.Add(phoneNumber, name);
                    
                    if(contacts.Count > 0 )
                    {
                        Console.WriteLine("{0,-20} {1}", "Contact Name", "Phone Number");
                        Console.WriteLine(new string('-', 40));
                        ICollection keys = contacts.Keys; //get all key
                        foreach (String phoneNum in keys)
                        {
                            string nameContact = (string)contacts[phoneNum];
                            Contact contact = new Contact(nameContact, phoneNum);
                            Console.WriteLine(contact.ToString());
                        }
                    }else{
                        Console.WriteLine("No contacts available.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving contacts: {ex.Message}");
            }
            finally
            {
            
                conn.Close();
            }

        }

        public void searchContactByName(String Name)
        {
            contacts.Clear();
            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT name, phoneNumber FROM Contact WHERE name = @name";
                cmd.Parameters.AddWithValue("@name", Name);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string phoneNumber = reader["phoneNumber"].ToString();
                    contacts.Add(phoneNumber, Name);
                }
                 if(contacts.Count > 0 )
                    {
                        Console.WriteLine("{0,-20} {1}", "Contact Name", "Phone Number");
                        Console.WriteLine(new string('-', 40));
                        ICollection keys = contacts.Keys; //get all key
                        foreach (String phoneNum in keys)
                        {
                            string nameContact = (string)contacts[phoneNum];
                            Contact contactByName = new Contact(nameContact, phoneNum);
                            Console.WriteLine(contactByName.ToString());
                        }
                    }else{
                        Console.WriteLine("No contacts available.");
                    }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error searching contact: {ex.Message}");
            }
            finally
            {
                conn.Close();
            }

        }
    }
}