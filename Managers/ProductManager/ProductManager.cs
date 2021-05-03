using Microsoft.EntityFrameworkCore;
using servPart.Models;
using servPart.Storage;
using servPart.Storage.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace servPart.Managers.ProductManager
{
    
    public class ProductManager : IProductManager, IProductQrcodeManager
    {
        private AshanContext _con;
        public ProductManager(AshanContext con)
        {
            _con = con;
        }

        public ProductQrcodewithType getbyID(int id)
        {
            ProductQrcodewithType X = new ProductQrcodewithType();
            ProductQrcodewithType Y = new ProductQrcodewithType();
            X = _con.ProductQrcodes.FirstOrDefault(st => st.id == id);
            Y = X;
            for (int i = 0; i < _con.Stocks.Count(); i++)
            {
                if (_con.Stocks[i].product == X) { X.Stock(_con.Stocks[i].Value); }
            }


            for (int i = 0; i < _con.StocksOfType.Count(); i++)
            {
                for (int j = 0; j < X.Types.Count(); j++)
                {
                    if (_con.StocksOfType[i].Type == X.Types[j] && Y.Price > (X.Stock(_con.Stocks[i].Value)).Price) { Y = X.Stock(_con.Stocks[i].Value); }
                }
            }

            return X;
        }

        public ProductQrcodewithType GetByQrcode(string Qr)
        {
            ProductQrcodewithType X = new ProductQrcodewithType();
            ProductQrcodewithType Y = new ProductQrcodewithType();

            X = _con.ProductQrcodes.FirstOrDefault(st => st.Qrcode == Qr);
            Y = X;
            for (int i =0; i< _con.Stocks.Count(); i++)
            {
                if (_con.Stocks[i].product == X ) { X.Stock(_con.Stocks[i].Value); return X; }
            }

            for (int i = 0; i < _con.StocksOfType.Count(); i++)
            {
                for (int j = 0; j < X.Types.Count(); j++)
                {
                    if (_con.StocksOfType[i].Type == X.Types[j] && Y.Price > (X.Stock(_con.Stocks[i].Value)).Price) { Y = X.Stock(_con.Stocks[i].Value); }
                }
            }


            return X;
        }


    }
}
