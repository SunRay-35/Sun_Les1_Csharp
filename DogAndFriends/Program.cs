int count = 0, distance = 10000,
    firstFriendSpeed = 1, secondFriendSpeed = 2,
    dogSpeed = 5, direction = 2;

int[] firstFriend = new int[2] {0, 1};
int[] secondFriend = new int[2] {100, 1};
int[] aloneDog = new int[2] {0, 1};

Console.WriteLine("Начинаем?");
Console.ReadLine();
Console.Clear();

while (distance > 10)
{
    int time = 0, animTime = 0;
// Console.SetCursorPosition(firstFriend[0], firstFriend[1]);
// Console.Write("*");
    if (direction == 1)
    {
        time = distance / (firstFriendSpeed + dogSpeed);
        direction = 2;
    }
    else
    {
        time = distance / (secondFriendSpeed + dogSpeed);
        direction = 1;
    };
    int startFirst = firstFriend[0];
    int startSecond = secondFriend[0];
    int startDog = aloneDog[0];
    while (animTime < time)
    {
        Console.Clear();
        Console.SetCursorPosition(firstFriend[0], firstFriend[1]);
        Console.Write("*");
        Console.SetCursorPosition(secondFriend[0], secondFriend[1]);
        Console.Write("*");
        Console.SetCursorPosition(aloneDog[0], aloneDog[1]);
        Console.Write(".");
        System.Threading.Thread.Sleep(5);
        firstFriend[0] = startFirst + firstFriendSpeed * animTime / 100;
        secondFriend[0] = startSecond - secondFriendSpeed * animTime / 100;
        if (direction == 1)
        {
             aloneDog[0] =  startDog + dogSpeed * animTime / 100;
        }
        else
        {
            aloneDog[0] =  startDog - dogSpeed * animTime / 100;
        };
        animTime++;
    };
    distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
    count++;
};
Console.SetCursorPosition(0, 2);
Console.Write("Собака пробежала: ");
Console.WriteLine(count);