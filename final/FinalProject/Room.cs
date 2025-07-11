 public class Room
    {
        private string _name;
        private string _description;
        private List<Room> _connectedRooms = new List<Room>();
        private List<ObjectInteraction> _objects = new List<ObjectInteraction>();

        public void Enter(Character character) { }
        public Room Exit(string direction) { return null; }
        public string Describe() { return _description; }
    }


