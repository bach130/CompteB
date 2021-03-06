﻿using Compte_Bancaire.BusinessObject;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compte_Bancaire.DAL
{
    class ClientDAO
    {
        public ClientDAO()
        {

        }
        Connexion conn = new Connexion();
        Client cl = new Client();
        public void afficherDataGridView(string table, DataGridView dg)
        {
            conn.connecter();
            conn.cmd.CommandText = "select * from " + table;
            conn.cmd.Connection = conn.conn;
            MySqlDataReader dr = conn.cmd.ExecuteReader();
            while (dr.Read())
            {
                dg.Rows.Add(dr[0], dr[1], dr[2], dr[3]);

            }
            dr.Close();
            conn.conn.Close();
        }
        //public void ajouter(DataGridView dg, TextBox tb, TextBox tb1, TextBox tb2)
        public void ajouter(string table,DataGridView dg, Client cl)
        {
            conn.connecter();
            conn.cmd.CommandText = "insert into client(nom,prenom,adresse) values('" + cl.NOM1 + "','" + cl.PRENOM1 + "','" + cl.Adresse + "')";
            conn.cmd.Connection = conn.conn;
            conn.cmd.ExecuteNonQuery();

            dg.Rows.Clear();
            afficherDataGridView(table, dg);
            conn.deconnecter();

        }
        //public void supprimer(string table, DataGridView dg, TextBox t)
        public void supprimer(string table, DataGridView dg, Client cl)
        {
            conn.connecter();
           // cl.NOM1 = tb.Text;
            conn.cmd.CommandText = "delete from client where nom='" + cl.NOM1 + "'";
            conn.cmd.Connection = conn.conn;
            conn.cmd.ExecuteNonQuery();

            dg.Rows.Clear();
            afficherDataGridView(table, dg);
            conn.deconnecter();

        }
        //public void modefierClient(TextBox tb, TextBox tb1, TextBox tb2, string table, DataGridView dg)
        public void modefierClient(Client cl, string table, DataGridView dg)
        {
            conn.connecter();
            conn.cmd.CommandText = "update client set nom='" + cl.NOM1 + "',prenom='" + cl.PRENOM1 + "',adresse='" + cl.Adresse + "'where numcl='" + cl.NUMCL1 + "'";
            conn.cmd.Connection = conn.conn;
            conn.cmd.ExecuteNonQuery();

            dg.Rows.Clear();
            afficherDataGridView(table, dg);
            conn.deconnecter();

        }
        public bool Exist(Client c,string table)
        {

            bool e = false;
            conn.connecter();
            conn.cmd.CommandText = "select * from'"+ table+"' where nom ='" + c.NOM1 + "'";
            conn.cmd.Connection = conn.conn;
            MySqlDataReader dr2 = conn.cmd.ExecuteReader();
            if (dr2.HasRows == true)
            {
                e = true;
            }
            dr2.Close();
            conn.deconnecter();
            return e;
        }
        public void rechercher(Client c,string table)
        {
            
            conn.connecter();
            conn.cmd.CommandText = "select * from'" + table + "' where nom ='" + c.NOM1 + "'";
            conn.cmd.Connection = conn.conn;
            MySqlDataReader drr = conn.cmd.ExecuteReader();
            if (drr.Read())
            {

                c.NUMCL1 = Convert.ToInt32(drr[0].ToString());
                c.NOM1 = drr[1].ToString();
                c.PRENOM1 = drr[2].ToString();
                c.Adresse = drr[3].ToString();

            }
            drr.Close();
            conn.deconnecter();
        }
    }
}
