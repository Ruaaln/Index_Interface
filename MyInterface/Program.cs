///////////////////////////////////////////////

//// Interface ( can do, multiple  )


using MyInterface.Interfaces;
using MyInterface.Models;

///
/// Inheritance ( is a ) 
/// Assosiasiont ( has a, part of, use a )

//var mercedes = new Mercedes();

//mercedes.Sport();


//ITurbo mercedes2 = new Mercedes();
//mercedes2.Turbo();



//(mercedes2 as IClassic)!.Classic();


List<IClassic> classics = new List<IClassic>();

classics.Add(new Mercedes());
classics.Add(new Lada());

foreach (var item in classics)
{
    item.Classic();
}



