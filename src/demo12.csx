Console.WriteLine("In case inputData is null");
int[] inputData = null;

var count = inputData?.Length;
Console.WriteLine("count: {0}", count);

var count2 = inputData?.Length ?? 0;
Console.WriteLine("count2: {0}", count2);

Console.WriteLine("In case inputData is not null");

inputData = new int[3];

var count3 = inputData?.Length;
Console.WriteLine("count3: {0}", count3);

if (count == null) {
    Console.WriteLine("Count is NULL");
} else {
    Console.WriteLine("Count is NOT NULL");
}