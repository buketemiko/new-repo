class CachedValue<T> where T : class
	{
		Func<T> CalculateProc;
		T LastCalculatedValue;

		public bool IsFrozen { get; private set; }
		public void Freeze () => IsFrozen = true;

		public CachedValue (Func<T> calculateProc)
		{
			CalculateProc = calculateProc;
		}

		public T Value {
			get {
				if (IsFrozen) {
					if (LastCalculatedValue == null)
						LastCalculatedValue = CalculateProc ();
					return LastCalculatedValue;
				} else {
					return CalculateProc ();
				}
//yes
	public override void WriteHeaders ()
		{
			headers.WriteLine ();
			WriteHeadersComment ();
			base.WriteHeaders ();
		}
