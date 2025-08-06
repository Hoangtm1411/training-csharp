namespace Basic_CSharp.Models.Emotions
{
	public interface IEmotionState
	{
		string Name { get; }
		void ModifyStats(Stats stats);
	}
}
