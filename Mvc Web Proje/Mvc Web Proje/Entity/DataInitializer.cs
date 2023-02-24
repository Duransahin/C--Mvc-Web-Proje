using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Mvc_Web_Proje.Entity
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var kategoriler = new List<Category>()
            {
                new Category(){ Name = "Kamera", Description = "Kamera ürünleri"},
                new Category(){ Name = "Bilgisayar", Description = "Bilgisayar ürünleri"},
                new Category(){ Name = "Televizyon", Description = "Televizyon ürünleri"},
                new Category(){ Name = "Telefon", Description = "Telefon ürünleri"},
                new Category(){ Name = "Eşya", Description = "Beyaz Eşya ürünleri"}
            };
            foreach (var kategori in kategoriler)
            {
                context.Categories.Add(kategori);
            }
            context.SaveChanges();
            var urunler = new List<Product>()
            {
                    new Product(){ Name = "Canon Eos 1200D 18-55 mm DC Profesyonel Dijital Fotoğraf Makinesi",Description = "Kullanmayı çok seveceğiniz ergonomik tasarım Optik vizör, çekiminizi oluşturmanıza ve tahmin etmenize olanak tanıyarak her zaman anın arkasındaki duyguyu yakalamak için hazır olmanızı sağlar. Sezgisel kullanımlı kullanıcı dostu kontrolleri ve görüntüyü incelemek için 7,5 cm'lik (3 inç) geniş LCD ekranıyla EOS 1200D'yi kullanması çok keyiflidir.", Price =1200 , Stock =500 , IsApproved =true , CategoryId = 1,IsHome = true,Image = "1.jpg"},
                    new Product(){ Name = "Canon Eos 100D 18-55 mm DC Profesyonel Fotoğraf Makines",Description = "Kullanmayı çok seveceğiniz ergonomik tasarım Optik vizör, çekiminizi oluşturmanıza ve tahmin etmenize olanak tanıyarak her zaman anın arkasındaki duyguyu yakalamak için hazır olmanızı sağlar. Sezgisel kullanımlı kullanıcı dostu kontrolleri ve görüntüyü incelemek için 7,5 cm'lik (3 inç) geniş LCD ekranıyla EOS 1200D'yi kullanması çok keyiflidir.", Price =1200 , Stock =500 , IsApproved =true , CategoryId = 1,IsHome = true,Image = "1.jpg"},
                    new Product(){ Name = "Canon Eos 700D 18-55 DC DSLR Fotoğraf Makinesi",Description = "Kullanmayı çok seveceğiniz ergonomik tasarım Optik vizör, çekiminizi oluşturmanıza ve tahmin etmenize olanak tanıyarak her zaman anın arkasındaki duyguyu yakalamak için hazır olmanızı sağlar. Sezgisel kullanımlı kullanıcı dostu kontrolleri ve görüntüyü incelemek için 7,5 cm'lik (3 inç) geniş LCD ekranıyla EOS 1200D'yi kullanması çok keyiflidir.", Price =1200 , Stock =500 , IsApproved =false , CategoryId = 1,IsHome = true,Image = "1.jpg"},
                    new Product(){ Name = "Canon Eos 100D 18-55 mm IS STM Kit DSLR Fotoğraf Makinesi",Description = "Kullanmayı çok seveceğiniz ergonomik tasarım Optik vizör, çekiminizi oluşturmanıza ve tahmin etmenize olanak tanıyarak her zaman anın arkasındaki duyguyu yakalamak için hazır olmanızı sağlar. Sezgisel kullanımlı kullanıcı dostu kontrolleri ve görüntüyü incelemek için 7,5 cm'lik (3 inç) geniş LCD ekranıyla EOS 1200D'yi kullanması çok keyiflidir.", Price =1200 , Stock =500 , IsApproved =true , CategoryId = 1,IsHome = true,Image = "1.jpg"},
                    new Product(){ Name = "Canon Eos 700D + 18-55 Is Stm + Çanta + 16 Gb Hafıza Kartı",Description = "Kullanmayı çok seveceğiniz ergonomik tasarım Optik vizör, çekiminizi oluşturmanıza ve tahmin etmenize olanak tanıyarak her zaman anın arkasındaki duyguyu yakalamak için hazır olmanızı sağlar. Sezgisel kullanımlı kullanıcı dostu kontrolleri ve görüntüyü incelemek için 7,5 cm'lik (3 inç) geniş LCD ekranıyla EOS 1200D'yi kullanması çok keyiflidir.", Price =1200 , Stock =500 , IsApproved =false , CategoryId = 1,IsHome=true,Image = "1.jpg"},

                    new Product(){ Name = "Dell Inspiron 15 3520 12.Nesil Core i5 1235U-8Gb-512Gb Ssd-15.6inc-W11 ",Description=" Kullanmayı çok seveceğiniz ergonomik tasarım Optik vizör, çekiminizi oluşturmanıza ve tahmin etmenize olanak tanıyarak her zaman anın arkasındaki duyguyu yakalamak için hazır olmanızı sağlar. Sezgisel kullanımlı kullanıcı dostu kontrolleri ve görüntüyü incelemek için 7,5 cm'lik (3 inç) geniş LCD ekranıyla EOS 1200D'yi kullanması çok keyiflidir.",Price=8500,Stock=50,IsApproved=true,CategoryId=2,IsHome=true,Image="2.jpg"},
                    new Product(){ Name = "Lenovo Ideapad 310 Intel Core i7 7500U 12GB 1TB GT920M Windows 10 Home 15.6 Taşınabilir Bilgisayar 80TV028XTX",Description = "Kullanmayı çok seveceğiniz ergonomik tasarım Optik vizör, çekiminizi oluşturmanıza ve tahmin etmenize olanak tanıyarak her zaman anın arkasındaki duyguyu yakalamak için hazır olmanızı sağlar. Sezgisel kullanımlı kullanıcı dostu kontrolleri ve görüntüyü incelemek için 7,5 cm'lik (3 inç) geniş LCD ekranıyla EOS 1200D'yi kullanması çok keyiflidir.", Price =4500 , Stock =1200 , IsApproved =true , CategoryId = 2,IsHome = true,Image = "3.jpg"},
                    new Product(){ Name = "Asus UX310UQ-FB418T Intel Core i7 7500U 8GB 512GB SSD GT940MX Windows 10 Home 13.3 QHD Taşınabilir Bilgisayar",Description = "Kullanmayı çok seveceğiniz ergonomik tasarım Optik vizör, çekiminizi oluşturmanıza ve tahmin etmenize olanak tanıyarak her zaman anın arkasındaki duyguyu yakalamak için hazır olmanızı sağlar. Sezgisel kullanımlı kullanıcı dostu kontrolleri ve görüntüyü incelemek için 7,5 cm'lik (3 inç) geniş LCD ekranıyla EOS 1200D'yi kullanması çok keyiflidir.", Price =3400 , Stock =0 , IsApproved =false , CategoryId = 2,IsHome = true,Image = "2.jpg"},
                    new Product(){ Name = "Asus UX310UQ-FB418T Intel Core i7 7500U 16GB 512GB SSD GT940MX Windows 10 Home 13.3 QHD Taşınabilir Bilgisayar",Description = "Kullanmayı çok seveceğiniz ergonomik tasarım Optik vizör, çekiminizi oluşturmanıza ve tahmin etmenize olanak tanıyarak her zaman anın arkasındaki duyguyu yakalamak için hazır olmanızı sağlar. Sezgisel kullanımlı kullanıcı dostu kontrolleri ve görüntüyü incelemek için 7,5 cm'lik (3 inç) geniş LCD ekranıyla EOS 1200D'yi kullanması çok keyiflidir.", Price =2500 , Stock =600 , IsApproved =true , CategoryId = 2,IsHome=true,Image = "3.jpg"},
                    new Product(){ Name = "Asus N580VD-DM160T Intel Core i7 7700HQ 16GB 1TB + 128GB SSD GTX1050 Windows 10 Home",Description = "Kullanmayı çok seveceğiniz ergonomik tasarım Optik vizör, çekiminizi oluşturmanıza ve tahmin etmenize olanak tanıyarak her zaman anın arkasındaki duyguyu yakalamak için hazır olmanızı sağlar. Sezgisel kullanımlı kullanıcı dostu kontrolleri ve görüntüyü incelemek için 7,5 cm'lik (3 inç) geniş LCD ekranıyla EOS 1200D'yi kullanması çok keyiflidir.", Price =5200,Stock=0 , IsApproved =true , CategoryId = 2,IsHome=true,Image = "2.jpg"},
            };
            foreach (var urun in urunler)
            {
                context.Products.Add(urun);
                context.SaveChanges();
            }
            base.Seed(context);
        }



    }
}