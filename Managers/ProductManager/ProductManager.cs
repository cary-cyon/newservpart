using Microsoft.EntityFrameworkCore;
//using servPart.Models;
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

        public ProductQrcodewithType getbyID(int id, int user_id)
        {

            ProductQrcodewithType X = new ProductQrcodewithType();

            X = _con.ProductQrcodes.Include(p => p.Types).Include(p => p.Image).FirstOrDefault(st => st.id == id);
            if (X != null)
            {
                if (_con.Stocks.FirstOrDefault(s => s.product == X) != null)
                {
                    X.Stock(_con.Stocks.FirstOrDefault(s => s.product == X).Value);
                }

                for (int i = 0; i < X.Types.Count(); i++)
                {
                    var test = _con.StocksOfType.FirstOrDefault(s => s.Type == X.Types[i]);
                    if (test != null)
                    {
                        X.Stock(test.Value);
                    }
                }
            }

            User U = new User();
            U = _con.Users.FirstOrDefault(st => st.ID == user_id);

            if (_con.StocksByClass.FirstOrDefault(s => s._class == U.userClass).products.FirstOrDefault(p => p == X) != null )
                { 
                    X.Stock(_con.StocksByClass.FirstOrDefault(s => s._class == U.userClass).Value); 
                }

            /*
                


                for (int i = 0; i < _con.StocksOfType.Count(); i++)
                {
                    for (int j = 0; j < X.Types.Count(); j++)
                    {
                        if (_con.StocksOfType[i].Type.name == X.Types[j] ) { X.Stock(_con.StocksOfType[i].Value); }
                    }
                }
            */
            return X;

        }

        public ProductQrcodewithType GetByQrcode(string Qr, int user_id)
        {

            ProductQrcodewithType X = new ProductQrcodewithType();
           

            X = _con.ProductQrcodes.Include(p => p.Types).FirstOrDefault(st => st.Qrcode == Qr);
            if (X != null)
            {
                if (_con.Stocks.FirstOrDefault(s => s.product == X) != null)
                {
                    X.Stock(_con.Stocks.FirstOrDefault(s => s.product == X).Value);
                }

                for (int i = 0; i < X.Types.Count(); i++)
                {
                    var test = _con.StocksOfType.FirstOrDefault(s => s.Type == X.Types[i]);
                    if (test != null)
                    {
                        X.Stock(test.Value);
                    }
                }
            }
            User U = new User();
            U = _con.Users.Include(p => p.userClass).FirstOrDefault(st => st.ID == user_id);
            if (U != null)
            {
                var res = _con.StocksByClass.Include(p => p.products).FirstOrDefault(s => s._class == U.userClass);
                if (res != null)
                {
                    if (res.products.FirstOrDefault(p => p == X) != null)
                    {
                        X.Stock(_con.StocksByClass.FirstOrDefault(s => s._class == U.userClass).Value);
                    }
                }
            }
            /*
            for (int i =0; i< _con.Stocks.Count(); i++)
            {
                if (_con.Stocks[i].product == X ) { X.Stock(_con.Stocks[i].Value); }
            }

            for (int i = 0; i < _con.StocksOfType.Count(); i++)
            {
                for (int j = 0; j < X.Types.Count(); j++)
                {
                    if (_con.StocksOfType[i].Type.name == X.Types[j]  ) { X.Stock(_con.StocksOfType[i].Value); }
                }
            }
           */

            return X;

        }

        public List<ProductQrcodewithType> ShowStocksProdukts(string Qr)
        {

            ProductQrcodewithType X = new ProductQrcodewithType();
            X = _con.ProductQrcodes.FirstOrDefault(st => st.Qrcode == Qr);
            List<ProductQrcodewithType> Y = new List<ProductQrcodewithType>();

            Stock1_1 s = _con.Stocks1_1.FirstOrDefault(  t =>t.products.FirstOrDefault(s => s == X) != null);
            if (s != null)
            {
                var z = s.products.Where(t => t != X);

                foreach (ProductQrcodewithType t in z)
                {
                    Y.Add(t);
                }

                for (int k = 0; k < Y.Count(); k++)
                {

                    Y[k].Stock(s.Value);
                }
            }


            /*
            for (int i = 0; i < _con.Stocks1_1.Count(); i++)
            {
                for (int j = 0; j < _con.Stocks1_1[i].products.Count(); j++) {

                    if (_con.Stocks1_1[i].products[j] == X) {

                        for (int k = 0; k < _con.Stocks1_1[i].products.Count(); k++)
                            if (_con.Stocks1_1[i].products[k] != X)
                            {
                                Y.Add(_con.Stocks1_1[i].products[k]);
                                l++;
                                Y[l].Stock(_con.Stocks1_1[i].Value);
                            }
                    }
                }
            }
            */
            return Y;
        }
/*
        public List<ProductQrcodewithType> DeletProductFromBase(int id, int k)
        {
            
            ProductQrcodewithType Tovar = new ProductQrcodewithType();
            Tovar = _con.ProductQrcodes.FirstOrDefault(st => st.id == id);
            if (Tovar != null)
            { 
                _con.ProductQrcodes.FirstOrDefault(st => st.id == id).count = _con.ProductQrcodes.FirstOrDefault(st => st.id == id).count- k;
                if (_con.ProductQrcodes.FirstOrDefault(st => st.id == id).count <= 0)
                {
                    _con.ProductQrcodes.Remove(_con.ProductQrcodes.FirstOrDefault(s => s.id == id));
                }
                
            }
            return _con.ProductQrcodes.ToList();
        }
*/
    }
}
