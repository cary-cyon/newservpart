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
           
            X = _con.ProductQrcodes.FirstOrDefault(st => st.id == id);
        
            for (int i = 0; i < _con.Stocks.Count(); i++)
            {
                if (_con.Stocks[i].product == X) { X.Stock(_con.Stocks[i].Value); }
            }


            for (int i = 0; i < _con.StocksOfType.Count(); i++)
            {
                for (int j = 0; j < X.Types.Count(); j++)
                {
                    if (_con.StocksOfType[i].Type == X.Types[j] ) { X.Stock(_con.Stocks[i].Value); }
                }
            }

            return X;
        }

        public ProductQrcodewithType GetByQrcode(string Qr)
        {
            ProductQrcodewithType X = new ProductQrcodewithType();
           

            X = _con.ProductQrcodes.FirstOrDefault(st => st.Qrcode == Qr);
          
            for (int i =0; i< _con.Stocks.Count(); i++)
            {
                if (_con.Stocks[i].product == X ) { X.Stock(_con.Stocks[i].Value); }
            }

            for (int i = 0; i < _con.StocksOfType.Count(); i++)
            {
                for (int j = 0; j < X.Types.Count(); j++)
                {
                    if (_con.StocksOfType[i].Type == X.Types[j]  ) { X.Stock(_con.Stocks[i].Value); }
                }
            }
           

            return X;
        }

        public List<ProductQrcodewithType> ShowStocksProdukts(string Qr)
        {
            ProductQrcodewithType X = new ProductQrcodewithType();
            X = _con.ProductQrcodes.FirstOrDefault(st => st.Qrcode == Qr);
            List<ProductQrcodewithType> Y = new List<ProductQrcodewithType>();
            
            for (int i = 0; i < _con.Stocks1_1.Count(); i++)
            {
                for (int j = 0; j < _con.Stocks1_1[i].products.Count(); j++) {

                    if (_con.Stocks1_1[i].products[j] == X) {

                        for (int k = 0; k < _con.Stocks1_1.Count(); k++)
                            if (_con.Stocks1_1[i].products[k] != X)
                            {
                                Y.Add(_con.Stocks1_1[i].products[k]);
                                Y[k].Stock(_con.Stocks1_1[i].Value);
                            }
                    }
                }
            }

            return Y;
        }


    }
}
