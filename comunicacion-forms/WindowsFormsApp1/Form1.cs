using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Finisar.SQLite;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_continuar_Click(object sender, EventArgs e)
        {
            string user, password;

            user = txt_usu.Text;
            password = txt_pass.Text;
            bool pasa = false;
            int tentos = 0;


           

            //validacion ----------------------------
            if (user == "" || password == "")
            {
                MessageBox.Show("Ningun campo puede estar vacio");
            }
            else
            {
                try
                {
                    //Utilizamos estos tres objetos de SQLite
                    SQLiteConnection conexion_sqlite;
                    SQLiteCommand cmd_sqlite;
                    SQLiteDataReader datareader_sqlite;

                    conexion_sqlite = new SQLiteConnection("Data Source=database.db;Version=3;Compress=True;");
                    conexion_sqlite.Open();

                    /////creo la tabla -------------------------------------------------------------------
                    //cmd_sqlite = conexion_sqlite.CreateCommand();
                    //cmd_sqlite.CommandText = "CREATE TABLE Users(id integer primary key, Nombre varchar(20), usuario varchar(25), password varchar(25));";
                    //cmd_sqlite.ExecuteNonQuery();



                    ////Insertando datos en la tabla -----------------------------------------------------------
                    //cmd_sqlite = conexion_sqlite.CreateCommand();
                    //cmd_sqlite.CommandText = "INSERT INTO Users VALUES (2,'OSCRA','osc','122')";
                    //cmd_sqlite.ExecuteNonQuery();



                    cmd_sqlite = conexion_sqlite.CreateCommand();
                    cmd_sqlite.ExecuteNonQuery();
                    cmd_sqlite.CommandText = "SELECT usuario FROM Users";
                    datareader_sqlite = cmd_sqlite.ExecuteReader();

                    while (datareader_sqlite.Read())
                    {
                        //Mostrando los datos

                        string lectura = datareader_sqlite.GetString(0);



                        lectura = lectura + datareader_sqlite.GetString(1);
                        MessageBox.Show(lectura);

                    }


                    conexion_sqlite.Close();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("error:  " + ex);
                }

            }





            //muestra

            //    if (user == "" || password == "") {
            //    MessageBox.Show("Ningun campo puede estar vacio");
            //}
            //else {
            //    if (user != "JUAN321")
            //    {
            //        MessageBox.Show("Usuario no encontrado");

            //    }
            //    else if (password != "123")
            //    {
            //        MessageBox.Show("Contraseña incoreccta");
            //        tentos++;

            //    }
            //    else if (user == "JUAN321" && password == "123")
            //    {
            //        pasa = true;
            //        Form2 ventana = new Form2(); 
            //        ventana.lbl_bien.Text = "BIENVENIDO " + user;
            //        ventana.Show();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Ambos campos son incorrectos");
            //    }
            //}

           



        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
