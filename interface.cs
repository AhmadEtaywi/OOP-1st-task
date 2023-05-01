namespace Animal  {

interface IMovable
{
    void MoveForward(int distance); 
    void MoveBackward(int distance);
    void TurnLeft(int degrees);
    void TurnRight(int degrees);
}

}