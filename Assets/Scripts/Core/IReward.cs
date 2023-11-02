namespace Core
{
    public interface IReward
    {
        public string DisplayName { get; }
        public void Claim();
    }
}