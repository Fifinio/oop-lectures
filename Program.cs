//globul
global using System.Numerics;
namespace RationalLib
{

	public readonly struct Rational
	{
		public readonly BigInteger Numerator{ get; init;};
		public readonly BigInteger Denominator{ get; init;};
		
		public readonly static Rational NaN 	= new (0, 0);
		public readonly static Rational Zero	= new (0, 1);
		public readonly static Rational One 	= new (1, 1);
		public readonly static Rational PositiveInfinity = new (1, 0);
		public readonly static Rational NegativeInfinity = new (-1, 0);

		#region ctor's
		public Rational(BigInteger numerator, BigInteger denominator)
		{
			Numerator = numerator;
			Denominator = denominator;

			var gcd = BigInteger.GreatestCommonDivisor(Numerator, Denominator);
			(Numerator, Denominator) = (Numerator / gcd, Denominator/ gcd);
		}	
		public Rational(BigInteger value): this(numerator: value, denominator: 1){}
		
		public Rational(long numerator, long denominator) : this(numerator:(BigInteger)numerator,denominator: (BigInteger)denominator)}
		
		#endregion

		public override ToString() => $"{Numerator}/{Denominator}";
	}
}



