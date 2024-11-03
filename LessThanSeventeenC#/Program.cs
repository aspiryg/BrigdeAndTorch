// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

// Initial array of 4 integers [1, 2, 5, 10]

int[] firstArray = new int[] { 1, 2, 5, 10 };

int a, b, c, d, e, f;

int sum = 0;
int attempt = 0;

int bigger1;
int smaller1;

int bigger2;
int smaller2;

int smaller3;
int bigger3;



for (int i = 0; i < firstArray.Length; i++)
{
    //Console.WriteLine("First Batch");
    a = firstArray[i];
    for (int j = i + 1; j < firstArray.Length; j++)
    {
        b = firstArray[j];
        //Console.WriteLine($"Subset: {a}, {b}");

        if (a + b < 17)
        {
            // The time taken to cross the bridge by the two people in the first batch
            if (a > b)
            {
                bigger1 = a;
                smaller1 = b;
            }
            else
            {
                bigger1 = b;
                smaller1 = a;
            }

            sum = bigger1;

            //Console.WriteLine($"The Combination of {a} and {b}");
            int[] firstBatch = new int[] { a, b };

            for (int k = 0; k < firstBatch.Length; k++)
            {
                int firstElement = firstBatch[k];
                int secondElement = firstBatch[k == 0 ? 1 : 0];
                int backPerson1 = secondElement;
                sum = bigger1 + backPerson1;
                //Console.WriteLine($"First Batch - Case {firstElement}");
                //Console.WriteLine($"{firstElement} will be kept after the bridge and {secondElement} will be sent back with the torch");

                //The remaining people before the bridge 
                int[] secondArray = new int[firstArray.Length - 1];

                for (int l = 0, m = 0; l < firstArray.Length; l++)
                {
                    if (firstArray[l] != firstElement)
                    {
                        secondArray[m] = firstArray[l];
                        m++;
                    }
                }

                //Console.WriteLine("The remaining items before the bridge are: " + secondArray[0] + " " + secondArray[1] + " " + secondArray[2]);
                //Console.WriteLine("Second Bacth");

                for (int n = 0; n < secondArray.Length; n++)
                {
                    c = secondArray[n];
                    for (int m = n + 1; m < secondArray.Length; m++)
                    {
                        d = secondArray[m];

                        // The time taken to cross the bridge by the two people in the second batch

                        if (c > d)
                        {
                            bigger2 = c;
                            smaller2 = d;
                        }
                        else
                        {
                            bigger2 = d;
                            smaller2 = c;
                        }

                        sum = bigger1 + backPerson1 + bigger2;

                        //Console.WriteLine($"Subset: {c}, {d}");

                        if (sum < 17)
                        {
                            //Console.WriteLine($"The Combination of {c} and {d}");
                            int[] secondBatch = new int[] { c, d };

                            for (int o = 0; o < secondBatch.Length; o++)
                            {
                                int thirdElement = secondBatch[o];
                                int fourthElement = secondBatch[o == 0 ? 1 : 0];

                                int[] afterGroup = new int[] { firstElement, thirdElement, fourthElement };
                                //Console.WriteLine($"The Elements after the bridge are: {firstElement}, {thirdElement}, {fourthElement}");

                                // The remaining people after the bridge
                                int[] remainingElements = new int[firstArray.Length - 3];
                                for (int p = 0, q = 0; p < firstArray.Length; p++)
                                {
                                    if (!afterGroup.Contains(firstArray[p]))
                                    {
                                        remainingElements[q] = firstArray[p];
                                        q++;
                                    }

                                }
                                //Console.WriteLine("The remaining item before the bridge is: " + remainingElements[0]);

                                for (int r = 0; r < afterGroup.Length; r++)
                                {
                                    //Console.WriteLine($"Second bacth - Case {afterGroup[r]}");

                                    int backPerson2 = afterGroup[r];
                                    int remainingPerson1 = afterGroup[r == 0 ? 1 : 0];
                                    int remainingPerson2 = afterGroup[r == 2 ? 1 : 2];

                                    //Console.WriteLine($"{backPerson2} will be sent back with the torch and {remainingPerson1} and {remainingPerson2} will be kept after the bridge");

                                    sum = bigger1 + backPerson1 + bigger2 + backPerson2;

                                    //.WriteLine("The total time taken to cross the bridge is: " + sum);

                                    //Console.WriteLine("Third Batch");

                                    int[] lastGroup = { remainingElements[0], backPerson2 };

                                    for (int s = 0; s < lastGroup.Length; s++)
                                    {
                                        e = lastGroup[s];
                                        for (int t = s + 1; t < lastGroup.Length; t++)
                                        {
                                            f = lastGroup[t];

                                            if (e > f)
                                            {
                                                bigger3 = e;
                                                smaller3 = f;
                                            }
                                            else
                                            {
                                                bigger3 = f;
                                                smaller3 = e;
                                            }

                                            sum = bigger1 + backPerson1 + bigger2 + backPerson2 + bigger3;
                                            attempt++;

                                            if (sum <= 17)
                                            {
                                                Console.WriteLine($" \nfirst Batch: {a}, {b}");
                                                Console.WriteLine("time taken: " + bigger1);
                                                Console.WriteLine($"Back Person: {backPerson1}");
                                                Console.WriteLine("time taken: " + (bigger1 + backPerson1));
                                                Console.WriteLine($"Second Batch: {c}, {d}");
                                                Console.WriteLine("time taken: " + (bigger1 + backPerson1 + bigger2));
                                                Console.WriteLine($"Back Person: {backPerson2}");
                                                Console.WriteLine("time taken: " + (bigger1 + backPerson1 + bigger2 + backPerson2));
                                                Console.WriteLine($"Third Batch: {e}, {f}");
                                                Console.WriteLine("time taken: " + (bigger1 + backPerson1 + bigger2 + backPerson2 + bigger3));
                                                Console.WriteLine($"The total time taken to cross the bridge is: {sum}");
                                                Console.WriteLine("Attempt: " + attempt);
                                            }
                                            //else
                                            //{
                                            //    Console.WriteLine($" \nfirst Batch: {a}, {b}");
                                            //    Console.WriteLine("time taken: " + bigger1);
                                            //    Console.WriteLine($"Back Person: {backPerson1}");
                                            //    Console.WriteLine("time taken: " + (bigger1 + backPerson1));
                                            //    Console.WriteLine($"Second Batch: {c}, {d}");
                                            //    Console.WriteLine("time taken: " + (bigger1 + backPerson1 + bigger2));
                                            //    Console.WriteLine($"Back Person: {backPerson2}");
                                            //    Console.WriteLine("time taken: " + (bigger1 + backPerson1 + bigger2 + backPerson2));
                                            //    Console.WriteLine($"Third Batch: {e}, {f}");
                                            //    Console.WriteLine("time taken: " + (bigger1 + backPerson1 + bigger2 + backPerson2 + bigger3));
                                            //    Console.WriteLine($"The total time taken to cross the bridge is: {sum}");
                                            //}
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

                Console.WriteLine("\n");
            }

        }
        else
        {
            Console.WriteLine("False");
        }
    }
}
