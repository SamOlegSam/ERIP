using Erip.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using System.Data.Entity;
using ClosedXML.Excel;

namespace Erip.Controllers
{
    public class HomeController : Controller
    {
        public ERIPEntities db = new ERIPEntities();

        public ActionResult Index()
        {
            SelectList usluga = new SelectList(db.S_Usluga, "n_usl", "n_usl");
            ViewBag.usluga = usluga;

            //IEnumerable<V_FULL> FUELList = db.V_FULL;
            //FUELList = db.V_FULL.ToList();
            //ViewBag.FUELList = FUELList;
            //return View(FUELList);

            return View();


            //IEnumerable<S_Client> ClientList = db.S_Client;
            //ClientList = db.S_Client.ToList();
            //ViewBag.ClientList = ClientList;
            //return View(ClientList);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        //Фильтр
        public List<V_FULL> filter(List<V_FULL> listForFilter, string DataS, string DataPo, string usluga)
        {
            List<V_FULL> Vac_filter_1 = new List<V_FULL>();
            if (DataS == "0")
            {
                Vac_filter_1 = listForFilter;
            }
            else
            {
                DateTime DDD = Convert.ToDateTime(DataS);
                Vac_filter_1 = listForFilter.Where(x => x.dlast >= DDD).ToList();
            }

            List<V_FULL> Vac_filter_2 = new List<V_FULL>();
            if (DataPo == "0")
            {
                Vac_filter_2 = Vac_filter_1;
            }
            else
            {
                DateTime DDDD = Convert.ToDateTime(DataPo);
                Vac_filter_2 = Vac_filter_1.Where(x => x.dlast <= DDDD).ToList();
            }

            List<V_FULL> Vac_filter_3 = new List<V_FULL>();
            if (usluga == "")
            {
                Vac_filter_3 = Vac_filter_2;
            }
            else
            {
                
                Vac_filter_3 = Vac_filter_1.Where(x => x.usluga == usluga).ToList();
            }


            return Vac_filter_3;
        }

        public ActionResult forfilter111(string DataS, string DataPo, string usluga)
        {

            List<V_FULL> List = new List<V_FULL>();
            List = db.V_FULL.ToList();

            List<V_FULL> H_after_filter = new List<V_FULL>();
            H_after_filter = filter(List, DataS, DataPo, usluga).ToList();


            return PartialView(H_after_filter);

        }

        public ActionResult forfilter(string DataS, string DataPo, string usluga)
        {
            try
            {
                DateTime DDD = Convert.ToDateTime(DataS);
                DateTime DDDD = Convert.ToDateTime(DataPo);

                IEnumerable<V_FULL> ListFool = db.V_FULL;
                //var ListFilter = ListFool.Where(dlast >= DDD);
                var ListFilter = from VFULL in ListFool
                                 where VFULL.dlast >= DDD && VFULL.dlast <= DDDD
                                 select VFULL;
                

                if (usluga != "" )
                {
                    ListFilter = ListFilter.Where(u => u.usluga == usluga).OrderBy(g=>g.dlast);
                    //ListFilter = ListFilter;
                }

                var after_filter = ListFilter.OrderBy(g => g.dlast).ToList();


                return PartialView(after_filter);
            }   
            catch(Exception ex)
            {
                return (PartialView(null));
            }
        }

        //----------Формирование отчета------------------------//

        public ActionResult Export(string DataS, string DataPo, string usluga)
        {

            DateTime DDD = Convert.ToDateTime(DataS);
            DateTime DDDD = Convert.ToDateTime(DataPo);
           
            
            List<V_FULL> Vod = new List<V_FULL>();
            Vod = db.V_FULL.Where(p=>p.dlast>=DDD).Where(f=>f.dlast<=DDDD).OrderBy(g => g.dlast).ToList();

            if (usluga != "")
            {
                
                Vod = Vod.Where(r => r.usluga == usluga).OrderBy(g => g.dlast).ToList();
            }

            var after_filter = Vod.ToList();




            var workbook = new XLWorkbook();
            var worksheet = workbook.Worksheets.Add("Лист1");

            //Шапка отчета//
            worksheet.Columns().AdjustToContents();

            worksheet.Cell("B" + 1).Value = "Открытое акционерное общество 'Гомельтранснефть Дружба'";
            
            worksheet.Cell("B" + 2).Value = "";
            worksheet.Cell("C" + 2).Style.Font.FontSize = 14;
            worksheet.Cell("C" + 1).Style.Font.FontSize = 14;
            //worksheet.Cell("C" + 3).Style.Font.FontSize = 14;
            //worksheet.Cell("C" + 3).Value = "";
            //worksheet.Cell("C" + 4).Style.Font.FontSize = 14;
            //worksheet.Cell("C" + 4).Value = "";
            //worksheet.Cell("C" + 5).Style.Font.FontSize = 14;
            //worksheet.Cell("C" + 5).Value = "";
            //worksheet.Cell("C" + 6).Style.Font.FontSize = 14;
            //worksheet.Cell("" + 6).Value = "";
            worksheet.Cell("B" + 3).Style.Font.FontSize = 20;
            worksheet.Cell("B" + 3).Value = "Распечатка услуг ЕРИП ";
            worksheet.Cell("B" + 4).Style.Font.FontSize = 20;
            worksheet.Cell("B" + 4).Value = "с "+DataS+" по "+DataPo;

            //создадим заголовки у столбцов
            worksheet.Cell("A" + 6).Value = "Дата";
            worksheet.Cell("B" + 6).Value = "Услуга";
            worksheet.Cell("C" + 6).Value = "ФИО";
            worksheet.Cell("D" + 6).Value = "Сумма";
            worksheet.Cell("E" + 6).Value = "Дата";
            worksheet.Cell("F" + 6).Value = "Стоимость";
            //worksheet.Cell("G" + 10).Value = "Гор.тел";
            //worksheet.Cell("H" + 10).Value = "Мед.ком";
            //worksheet.Cell("I" + 10).Value = "Филиал";
            //worksheet.Cell("J" + 10).Value = "Подразд.";
            //worksheet.Cell("K" + 10).Value = "Должность";
            //worksheet.Cell("L" + 10).Value = "Класс";
            //worksheet.Cell("M" + 10).Value = "№ пасп.";
            //worksheet.Cell("N" + 10).Value = "Серия";
            //worksheet.Cell("O" + 10).Value = "Номер";
            //worksheet.Cell("P" + 10).Value = "Прописка";
            //worksheet.Cell("Q" + 10).Value = "Проживание";
            //worksheet.Cell("R" + 10).Value = "Выдан";
            //worksheet.Cell("S" + 10).Value = "Срок действ.";
            //worksheet.Cell("T" + 10).Value = "№ вод.уд.";
            //worksheet.Cell("U" + 10).Value = "Срок действ.";
            //worksheet.Cell("V" + 10).Value = "Категории";
            //worksheet.Cell("W" + 10).Value = "№ воен.бил.";
            //worksheet.Cell("X" + 10).Value = "Звание";


            for (int i = 0; i < Vod.Count; i++)
            {
                worksheet.Cell("A" + (i + 7)).Value = Vod[i].msgDT;
                worksheet.Cell("B" + (i + 7)).Value = Vod[i].usluga;
                worksheet.Cell("C" + (i + 7)).Value = Vod[i].fio;
                worksheet.Cell("D" + (i + 7)).Value = Vod[i].paysum;
                worksheet.Cell("E" + (i + 7)).Value = Vod[i].dlast;
                worksheet.Cell("F" + (i + 7)).Value = Vod[i].zachsum;

                //worksheet.Cell("G" + (i + 11)).Value = Vod[i].PhoneGor;
                //worksheet.Cell("H" + (i + 11)).Value = Vod[i].MedKomis;
                //worksheet.Cell("I" + (i + 11)).Value = Vod[i].Filial.Filial1;
                //if (Vod[i].Podrazd.Podrazd1 == null)
                //{
                //    worksheet.Cell("J" + (i + 11)).Value = "";
                //}
                //else
                //{
                //    worksheet.Cell("J" + (i + 11)).Value = Vod[i].Podrazd.Podrazd1;
                //}
                //if (Vod[i].Doljnost.Doljnost1 == null)
                //{
                //    worksheet.Cell("K" + (i + 11)).Value = "";
                //}
                //else
                //{
                //    worksheet.Cell("K" + (i + 11)).Value = Vod[i].Doljnost.Doljnost1;
                //}
                //if (Vod[i].Klass == null)
                //{
                //    worksheet.Cell("L" + (i + 11)).Value = "";
                //}
                //else
                //{
                //    worksheet.Cell("L" + (i + 11)).Value = Vod[i].Klass;
                //}
                //worksheet.Cell("M" + (i + 11)).Value = Vod[i].Passport.IDNumber;
                //worksheet.Cell("N" + (i + 11)).Value = Vod[i].Passport.Seria;
                //worksheet.Cell("O" + (i + 11)).Value = Vod[i].Passport.Number;
                //worksheet.Cell("P" + (i + 11)).Value = Vod[i].Passport.Propis;
                //worksheet.Cell("Q" + (i + 11)).Value = Vod[i].Address;
                //worksheet.Cell("R" + (i + 11)).Value = Vod[i].Passport.Vidan;
                //worksheet.Cell("S" + (i + 11)).Value = Vod[i].Passport.Srok;
                //worksheet.Cell("T" + (i + 11)).Value = Vod[i].VodUd.Number;
                //worksheet.Cell("U" + (i + 11)).Value = Vod[i].VodUd.SrokD;

                //worksheet.Cell("V" + (i + 11)).Value = Vod[i].VodUd.A + Vod[i].VodUd.A1 + Vod[i].VodUd.AM + Vod[i].VodUd.B + Vod[i].VodUd.C + Vod[i].VodUd.D + Vod[i].VodUd.BE + Vod[i].VodUd.CE + Vod[i].VodUd.DE + Vod[i].VodUd.F + Vod[i].VodUd.I;

                //worksheet.Cell("W" + (i + 11)).Value = Vod[i].VoenBilet.Number;
                //worksheet.Cell("X" + (i + 11)).Value = Vod[i].VoenBilet.Zvanie.Trim();


                //worksheet.Cell("J" + (i + 11)).Style.Fill.BackgroundColor = XLColor.AliceBlue;
                //worksheet.Cell("R" + (i + 11)).Style.Fill.BackgroundColor = XLColor.AliceBlue;
                //worksheet.Cell("U" + (i + 11)).Style.Fill.BackgroundColor = XLColor.AliceBlue;
                //worksheet.Cell("w" + (i + 11)).Style.Fill.BackgroundColor = XLColor.AliceBlue;
            }

            //пример изменения стиля ячейки
            worksheet.Cell("A" + 6).Style.Fill.BackgroundColor = XLColor.AliceBlue;
            worksheet.Cell("B" + 6).Style.Fill.BackgroundColor = XLColor.AliceBlue;
            worksheet.Cell("C" + 6).Style.Fill.BackgroundColor = XLColor.AliceBlue;
            worksheet.Cell("D" + 6).Style.Fill.BackgroundColor = XLColor.AliceBlue;
            worksheet.Cell("E" + 6).Style.Fill.BackgroundColor = XLColor.AliceBlue;
            worksheet.Cell("F" + 6).Style.Fill.BackgroundColor = XLColor.AliceBlue;
            //worksheet.Cell("G" + 10).Style.Fill.BackgroundColor = XLColor.AliceBlue;
            //worksheet.Cell("H" + 10).Style.Fill.BackgroundColor = XLColor.AliceBlue;
            //worksheet.Cell("I" + 10).Style.Fill.BackgroundColor = XLColor.AliceBlue;
            //worksheet.Cell("J" + 10).Style.Fill.BackgroundColor = XLColor.AliceBlue;
            //worksheet.Cell("K" + 10).Style.Fill.BackgroundColor = XLColor.AliceBlue;
            //worksheet.Cell("L" + 10).Style.Fill.BackgroundColor = XLColor.AliceBlue;
            //worksheet.Cell("M" + 10).Style.Fill.BackgroundColor = XLColor.AliceBlue;
            //worksheet.Cell("N" + 10).Style.Fill.BackgroundColor = XLColor.AliceBlue;
            //worksheet.Cell("O" + 10).Style.Fill.BackgroundColor = XLColor.AliceBlue;
            //worksheet.Cell("P" + 10).Style.Fill.BackgroundColor = XLColor.AliceBlue;
            //worksheet.Cell("Q" + 10).Style.Fill.BackgroundColor = XLColor.AliceBlue;
            //worksheet.Cell("R" + 10).Style.Fill.BackgroundColor = XLColor.AliceBlue;
            //worksheet.Cell("S" + 10).Style.Fill.BackgroundColor = XLColor.AliceBlue;
            //worksheet.Cell("T" + 10).Style.Fill.BackgroundColor = XLColor.AliceBlue;
            //worksheet.Cell("U" + 10).Style.Fill.BackgroundColor = XLColor.AliceBlue;
            //worksheet.Cell("V" + 10).Style.Fill.BackgroundColor = XLColor.AliceBlue;
            //worksheet.Cell("W" + 10).Style.Fill.BackgroundColor = XLColor.AliceBlue;
            //worksheet.Cell("X" + 10).Style.Fill.BackgroundColor = XLColor.AliceBlue;


            var rngTable = worksheet.Range("A6:F" + (Vod.Count + 6));
            rngTable.Style.Border.RightBorder = XLBorderStyleValues.Thin;
            rngTable.Style.Border.BottomBorder = XLBorderStyleValues.Thin;


            //-------------------------------------------------//
            var rngTable111 = worksheet.Range("A6:f" + 6);
            rngTable111.Style.Border.RightBorder = XLBorderStyleValues.Medium;
            rngTable111.Style.Border.BottomBorder = XLBorderStyleValues.Medium;
            rngTable111.Style.Border.LeftBorder = XLBorderStyleValues.Medium;
            rngTable111.Style.Border.TopBorder = XLBorderStyleValues.Medium;

            var col1 = worksheet.Column("A");
            col1.AdjustToContents();

            var col2 = worksheet.Column("B");
            col2.Width = 40;

            var col3 = worksheet.Column("C");
            col3.Width = 40;

            var col4 = worksheet.Column("D");
            col4.Width = 14;

            var col5 = worksheet.Column("E");
            col5.Width = 18;

            var col6 = worksheet.Column("F");
            col5.Width = 18;

            //worksheet.Columns().AdjustToContents();

            //worksheet.Column(1).Style.Alignment.WrapText = true;
            //worksheet.Column(2).Style.Alignment.WrapText = true;
            //worksheet.Column(3).Style.Alignment.WrapText = true;
            //worksheet.Column(4).Style.Alignment.WrapText = true;
            //worksheet.Column(6).Style.Alignment.WrapText = true;

            // вернем пользователю файл без сохранения его на сервере
            using (MemoryStream stream = new MemoryStream())
            {
                workbook.SaveAs(stream);
                return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Report.xlsx");
            }
        }


    }
}