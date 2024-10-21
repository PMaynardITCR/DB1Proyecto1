using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Olimpiadas.Modelos
{
    
    class Persona
    {
        int Id_person { get; set; }
        String First_name { get; set; }
        String Middle_name { get; set; }
        String First_surname { get; set; }
        String Second_surname { get; set; }
        DateTime Date_of_birth { get; set; }
        int Id_gender { get; set; }
        int Id_id_type { get; set; }
        String Photograph { get; set; }
        String telefono { get; set; }

        public Persona()
        {
        }

        public Persona(int id_person, string first_name, string middle_name, string first_surname, string second_surname, DateTime date_of_birth, int id_gender, int id_id_type, string photograph, int id_person1, string first_name1, string middle_name1, string first_surname1, string second_surname1, DateTime date_of_birth1, int id_gender1, int id_id_type1, string photograph1)
        {
            Id_person = id_person;
            First_name = first_name;
            Middle_name = middle_name;
            First_surname = first_surname;
            Second_surname = second_surname;
            Date_of_birth = date_of_birth;
            Id_gender = id_gender;
            Id_id_type = id_id_type;
            Photograph = photograph;
        }
    }
}
