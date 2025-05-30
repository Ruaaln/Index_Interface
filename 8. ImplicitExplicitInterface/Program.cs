using _8._ImplicitExplicitInterface.Models;

var some = new Some();

some.Get();

((IA)some).Get();
((IB)some).Get();