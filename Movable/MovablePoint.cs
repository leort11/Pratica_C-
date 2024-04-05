public class MovablePoint
{
    private int x;
    private int y;
    private int speed;
    public MovablePoint(int x, int y, int speed)
    {
        this.x = x;
        this.y = y;
        this.speed = speed;
    }

    public void MoveUp() this.y += this.speed;


    public void MoveDown() this.y -= this.speed;
    

    public void MoveLeft() this.x -= this.speed;

    public void MoveRight() this.x += this.speed;

    public string ToString() return $"MovablePoint[x = {this.x}, y = {this.y}, speed = {this.speed}]";
}