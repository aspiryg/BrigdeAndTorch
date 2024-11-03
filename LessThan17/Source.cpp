#include <iostream>
#include <string>
#include <vector>



using namespace std;

//void removeElement(int arr[], int n, int i)
//{
//	// If the array is empty or the index is out of bounds, return
//	if (n == 0 || i >= n)
//		return;
//
//	// Shift elements of the array to the left from index i
//	for (int j = i; j < n - 1; j++)
//		arr[j] = arr[j + 1];
//}

vector<int> removeElementAtIndex(const int arr[], int n, int index) {
	vector<int> result;

	for (int i = 0; i < n; ++i) {
		if (i != index) {
			result.push_back(arr[i]);
		}
	}

	return result;
}


int main()
{
	// Initial array of 4 elements [1, 2, 5, 10], name the array mainArray
	int mainArray[4] = { 1, 2, 5, 10 };

	int n = sizeof(mainArray) / sizeof(mainArray[0]);

	int time = 0;

	for (int i = 0; i < n; i++)
	{
		for (int j = i + 1; j < n; j++)
		{
			if (mainArray[i] + mainArray[j] < 17) 
			{
				if (mainArray[i] > mainArray[j]) {
					time = mainArray[i];
				}
				else {
					time = mainArray[j];
				}
				

				vector<int> firstCom = { mainArray[i], mainArray[j] };

				cout << "The first combination is: ";
				for (int k = 0; k < firstCom.size(); k++) {
					cout << firstCom[k] << ", ";
				}
				cout << endl;

				for (int k = 0; k < firstCom.size(); k++) {
					int firstElement = firstCom[k];

					int index = -1;
					for (int l = 0; l < n; l++) {
						if (mainArray[l] == firstElement) {
							index = l;
							break;

						}
					}

					int secondElement = -1;

					if (k == 1) {
						secondElement = firstCom[0];
					}
					else {
						secondElement = firstCom[1];
					}




					// Remove the element at the index from the mainArray
					vector<int> newMainArray = removeElementAtIndex(mainArray, n, index);


					cout << "The new mainArray afer subtracting " << firstElement << " and returning: " << secondElement << " is: ";
					for (int m = 0; m < newMainArray.size(); m++) {
						cout << newMainArray[m] << ", ";
					}
					cout << endl;


					for (int m = 0; m < newMainArray.size(); m++) {
						for (int n = m + 1; n < newMainArray.size(); n++) {
							if (newMainArray[m] > newMainArray[n]) {
								time = newMainArray[m] + secondElement + firstElement;
							}
							else {
								time = newMainArray[n] + secondElement + firstElement;
							}
							if (time < 17) {
								vector<int> secondCom = { newMainArray[m], newMainArray[n] };
								cout << "The second combination is: ";
								for (int o = 0; o < secondCom.size(); o++) {
									cout << secondCom[o] << ", ";
								}
								cout << endl;
								cout << "The time of the two combinations is: " << time << endl;

								for (int p = 0; p < secondCom.size(); p++) {
									int thirdElement = secondCom[p];

									int index = -1;
									for (int l = 0; l < n; l++) {
										if (newMainArray[l] == thirdElement) {
											index = l;
											break;

										}
									}

									int fourthElement = -1;

									if (p == 1) {
										fourthElement = secondCom[0];
									}
									else {
										fourthElement = secondCom[1];
									}


									vector<int> newMainArray = removeElementAtIndex(mainArray, n, index);

									// Print the new mainArray
									cout << "The new mainArray afer subtracting " << thirdElement << " and returning: " << fourthElement << " is: ";
									for (int m = 0; m < newMainArray.size(); m++) {
										cout << newMainArray[m] << ", ";
									}
									cout << endl;

								}
							}

						}

					}
				}
			}
		}
	}
}