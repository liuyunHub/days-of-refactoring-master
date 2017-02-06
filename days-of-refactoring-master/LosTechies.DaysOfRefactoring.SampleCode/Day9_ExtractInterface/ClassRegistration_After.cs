namespace LosTechies.DaysOfRefactoring.ExtractInterface.After
{
    /// <summary>
    /// 降低耦合度，也就是调用者只用到create和total，如果以后修改ClassRegistration的话就需要修改RegistrationProcessor，如果是改为接口调用，就不需要修改RegistrationProcessor中
    /// </summary>
	public interface IClassRegistration
	{
		void Create();
		decimal Total { get; }
	}

	public class ClassRegistration : IClassRegistration
	{
		public void Create()
		{
			// create registration code
		}

		public void Transfer()
		{
			// class transfer code
		}

		public decimal Total { get; private set; }
	}

	public class RegistrationProcessor
	{
		public decimal ProcessRegistration(IClassRegistration registration)
		{
			registration.Create();
			return registration.Total;
		}
	}
}
