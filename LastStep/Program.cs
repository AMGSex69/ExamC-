string[] stringsArrays = new string[] { };

int n = InputNumbers("Желаемое количество элементов массива: ");
stringsArrays = new string[n];
for (int i = 0; i < stringsArrays.Length; i++)
{
	Console.Write($" Введите строку № {i + 1} : ");
	stringsArrays[i] = Console.ReadLine();
}

int elementsLimit = 3;

int numbersItems = CheckArray(stringsArrays, elementsLimit);

string[] newstringsArrays = new string[numbersItems];

CompleteNewArray(stringsArrays, newstringsArrays, elementsLimit);

Console.WriteLine($"{PrintArray(newstringsArrays)}");


void CompleteNewArray(string[] oldArray, string[] newArray, int elementsLimit)
{
	int temp = 0;
	for (int i = 0; i < oldArray.Length; i++)
	{
		if (oldArray[i].Length <= elementsLimit)
		{
			newArray[temp] = oldArray[i];
			temp++;
		}
	}
}

int CheckArray(string[] array, int elementsLimit)
{
	int result = 0;
	for (int i = 0; i < array.Length; i++)
	{
		if (array[i].Length <= elementsLimit) result++;
	}
	return result;
}

string PrintArray(string[] array)
{
	string result = string.Empty;
	result = "[ ";
	for (int i = 0; i < array.Length; i++)
	{
		result += $"{array[i],1}";
		if (i < array.Length - 1) result += ", ";
	}
	result += " ]";
	return result;
}

int InputNumbers(string input)
{
	Console.Write(input);
	int output = Convert.ToInt32(Console.ReadLine());
	return output;
}