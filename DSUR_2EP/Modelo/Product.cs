﻿namespace DSUR_2EP.Modelo
{
    public class Product
    {
        public int idProduct { get; set; }
        public int idBusiness { get; set; }
        public string name { get; set; }

        public Product()
        {
            idProduct = 1;
            name = "";
            idBusiness = 1;
        }
    }
}