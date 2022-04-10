using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stage_2.Lesson_9_Task_Hovo
{
    interface ICafeMenu
    {
        string espresso { get; set; }
        string amerikano { get; set; }
        string latte { get; set; }
        string glasse { get; set; }
    }
    interface ICafeMenuPrices
    {
        int espressoPrice { get; set; }
        int americanoPrice { get; set; }
        int lattePrice { get; set; }
        int glassePrice { get; set; }
    }

    interface IRestMenu
    {
        string barbecue { get; set; }
        string omelet { get; set; }
        string salad { get; set; }
        string fish { get; set; }
    }
    interface IRestMenuPrices
    {
        int barbecuePrice { get; set; }
        int omeletPrice { get; set; }
        int saladPrice { get; set; }
        int fishPrice { get; set; }
    }

    interface IPizzaMenu
    {
        string neapolitan { get; set; }
        string chicago { get; set; }
        string greek { get; set; }
        string california { get; set; }
    }
    interface IPizzaMenuPrices
    {
        int neapolitanPrice { get; set; }
        int chicagoPrice { get; set; }
        int greekPrice { get; set; }
        int californiaPrice { get; set; }
    }

    interface ICafeMenuTimes
    {
        int espressoTime { get; set; }
        int amerikanoTime { get; set; }
        int latteTime { get; set; }
        int glasseTime { get; set; }
    }
    interface IRestMenuTimes
    {
        int barbecueTime { get; set; }
        int omeletTime { get; set; }
        int saladTime { get; set; }
        int fishTime { get; set; }
    }
    interface IPizzaMenuTimes
    {
        int neapolitanTime { get; set; }
        int chicagoTime { get; set; }
        int greekTime { get; set; }
        int californiaTime { get; set; }
    }
}
