namespace classes_game
{
    public class bld
    {
        public int speed, cost, uses, num;
        public string resourse;
        public bld (int speed, int cost, int uses, string resourse, int num)
        {
            this.speed = speed;
            this.cost = cost;
            this.uses = uses;
            this.resourse = resourse;
            this.num = num;
        }
    }
    public class res
    {
        public string name;
        public int num;
        public res (string name, int num)
        {
            this.name = name;
            this.num = num;
        }
    }
    public class events
    {
        public string name;
        public string desc;
        public byte good_ans;
        public events (string name, string desc, byte good_ans)
        {
            this.name = name;
            this.desc = desc;
            this.good_ans = good_ans;
        }
    }
}