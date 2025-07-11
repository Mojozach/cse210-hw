public class Traps
{
    private string _trapType;
    private int _damage;
    private bool _isHidden;

    public void Trigger(Character character) { }
    public bool Disarm() { return false; }
}