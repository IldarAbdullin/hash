/*
��������: */

#include <iostream>
#include <time.h>
#include <iomanip>
using namespace std;

void main()
{
	srand(time(NULL));
	setlocale( LC_ALL,"Russian" );
	int const n = 10;
	double a[n];
	int k = 0;  //���������� ��������������� ���������
    double sum = 0; //�� �����
	double sred = 0;  //������� ��������������
	for (int i=0;i<n;i++)
	{
		a[i] = (double)(rand()%10 - 6);
	}
	for (int i=0;i<n;i++)
	{
		cout<<setw(4)<<a[i];
	}
	for (int i=0;i<n;i++)
	{
		if(a[i] >= 0) 
		{
		  k = k + 1;
		  sum = sum + a[i];
		}
	}
    sred=sum/k;
	cout<<endl<<"������� �������������� ��������������� �����="<<sred<<endl;
	for (int i=0;i<n;i++)
	{
		if (a[i] < 0) 
		{
		  a[i]=a[i]+sred;
		}
	}
  for (int i=0;i<n;i++)
	{
		cout<<setw(5)<<a[i];
	}
  cout<<endl;
  system("pause");
}