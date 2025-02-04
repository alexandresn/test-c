﻿namespace BelezaNaWeb.Domain.Model
{
    public class Warehouse
    {
        public Warehouse(string locality, int quantity, string type)
        {
            Locality = locality;
            Quantity = quantity;
            Type = type;
        }

        public string Locality { get; private set; }
        public int Quantity { get; private set; }
        public string Type { get; private set; }
    }
}
