#include <stdio.h>
#include <iostream>
#include <math.h>
using namespace std;
#include <string>
#include <bitset>



void  xuat( string A);
void  xuatmang( string A);
string Xor(string a, string b);
string convertDecimalToBinary(int decimal);
int convertBinaryToDecimal(string binary);
string LCS(string A);
string LCS2(string A);
string usePC1(string K,int pc1[]);
string useinitialpermutation(string A,int IP[]);
string usePC2(string K,int pc2[]);
string useE(string A,int pc2[]);
string usePer(string A,int per[]);
string Sbox(int sbox[][4][16],string newRK);
void mahoa(int IP[],int IIP[],int pc1[],int pc2[],int per[],int E[],int sbox[][4][16],string rA,string lA,string out,string K,int dem);
void giaima(int IP[],int IIP[],int pc1[],int pc2[],int per[],int E[],int sbox[][4][16],string rA,string lA,string out,string K,int dem);
string RCS(string A);
string RCS2(string A);
void sinhK(string k,int dem,int yeucau,string &GhepK);



int main()
{	

	string IN=""; 
	unsigned int hex=0x43A9B541A3CDA5B ; 
	bitset<64> bits(hex); 
	IN=bits.to_string(); 

	xuat(IN);
	
	
	string A="1111010000111010100110110101010000011010001111001101101001011011";
	//K = 13345799BBCDDFF1
	string k="0001001100110100010101111001100110111011110011011101111111110001";
	string out;
	
	int E[48]=
	{
		32, 1, 2, 3, 4, 5,
		4, 5, 6, 7, 8, 9, 
		8, 9, 10, 11, 12, 13,
		12, 13, 14, 15, 16, 17,
		16, 17, 18, 19, 20, 21,
		20, 21, 22, 23, 24, 25,
		24, 25, 26, 27, 28, 29,
		28, 29, 30, 31, 32, 1
	};
	
	int IP [64]=
	{58,50,42,34,26,18,10,2,60,52,44,36,28,20,12,4,62,54,46,38,30,22,14,6,64,56,48,40,32,24,16,8,57,49,41,33,25,17,9,1,59,51,43,35,27,19,11,3,61,53,45,37,29,21,13,5,63,55,47,39,31,23,15,7 
	};
	int IIP[64]= 
	{ 
	40,8,48,16,56,24,64,32, 
	39,7,47,15,55,23,63,31, 
	38,6,46,14,54,22,62,30, 
	37,5,45,13,53,21,61,29, 
	36,4,44,12,52,20,60,28, 
	35,3,43,11,51,19,59,27, 
	34,2,42,10,50,18,58,26, 
	33,1,41,9,49,17,57,25 
	};
	int Per[32]={16,7,20,21,29,12,28,17, 
	1,15,23,26,5,18,31,10, 
	2,8,24,14,32,27,3,9,
	19,13,30,6,22,11,4,25 
	};
	
	int pc1[56] = {
	57,49,41,33,25,17,9, 
	1,58,50,42,34,26,18, 
	10,2,59,51,43,35,27, 
	19,11,3,60,52,44,36,		 
	63,55,47,39,31,23,15, 
	7,62,54,46,38,30,22, 
	14,6,61,53,45,37,29, 
	21,13,5,28,20,12,4 
	};
	int pc2[48] = { 
	14,17,11,24,1,5, 
	3,28,15,6,21,10, 
	23,19,12,4,26,8, 
	16,7,27,20,13,2, 
	41,52,31,37,47,55, 
	30,40,51,45,33,48, 
	44,49,39,56,34,53, 
	46,42,50,36,29,32 
	};
	int sbox[8][4][16]=  
	{{ 
        14,4,13,1,2,15,11,8,3,10,6,12,5,9,0,7, 
        0,15,7,4,14,2,13,1,10,6,12,11,9,5,3,8, 
        4,1,14,8,13,6,2,11,15,12,9,7,3,10,5,0, 
        15,12,8,2,4,9,1,7,5,11,3,14,10,0,6,13 
    }, 
    { 
        15,1,8,14,6,11,3,4,9,7,2,13,12,0,5,10, 
        3,13,4,7,15,2,8,14,12,0,1,10,6,9,11,5, 
        0,14,7,11,10,4,13,1,5,8,12,6,9,3,2,15, 
        13,8,10,1,3,15,4,2,11,6,7,12,0,5,14,9 
    }, 
    { 
        10,0,9,14,6,3,15,5,1,13,12,7,11,4,2,8, 
        13,7,0,9,3,4,6,10,2,8,5,14,12,11,15,1, 
        13,6,4,9,8,15,3,0,11,1,2,12,5,10,14,7, 
        1,10,13,0,6,9,8,7,4,15,14,3,11,5,2,12 
    }, 
    { 
        7,13,14,3,0,6,9,10,1,2,8,5,11,12,4,15, 
        13,8,11,5,6,15,0,3,4,7,2,12,1,10,14,9, 
        10,6,9,0,12,11,7,13,15,1,3,14,5,2,8,4, 
        3,15,0,6,10,1,13,8,9,4,5,11,12,7,2,14 
    }, 
    { 
        2,12,4,1,7,10,11,6,8,5,3,15,13,0,14,9, 
        14,11,2,12,4,7,13,1,5,0,15,10,3,9,8,6, 
        4,2,1,11,10,13,7,8,15,9,12,5,6,3,0,14, 
        11,8,12,7,1,14,2,13,6,15,0,9,10,4,5,3 
    }, 
    { 
        12,1,10,15,9,2,6,8,0,13,3,4,14,7,5,11, 
        10,15,4,2,7,12,9,5,6,1,13,14,0,11,3,8, 
        9,14,15,5,2,8,12,3,7,0,4,10,1,13,11,6, 
        4,3,2,12,9,5,15,10,11,14,1,7,6,0,8,13 
    }, 
    { 
        4,11,2,14,15,0,8,13,3,12,9,7,5,10,6,1, 
        13,0,11,7,4,9,1,10,14,3,5,12,2,15,8,6, 
        1,4,11,13,12,3,7,14,10,15,6,8,0,5,9,2, 
        6,11,13,8,1,4,10,7,9,5,0,15,14,2,3,12 
    }, 
    { 
        13,2,8,4,6,15,11,1,10,9,3,14,5,0,12,7, 
        1,15,13,8,10,3,7,4,12,5,6,11,0,14,9,2, 
        7,11,4,1,9,12,14,2,0,6,10,13,15,3,5,8, 
        2,1,14,7,4,10,8,13,15,12,9,0,3,5,6,11 
    }};   	
    
    int a;
	cout<<"Chon 1 de Ma Hoa, 0 de Giai Ma ";
	cin>>a;
	
	
	if(a==1)
	{	
		int dem=1;
		string newA=useinitialpermutation(A,IP);	  
		string left = newA.substr(0, 32); 
		string right = newA.substr(32, 32);
		k=usePC1(k,pc1);
		xuat(k); 
		mahoa(IP, IIP,pc1,pc2,Per,E,sbox,right,left,out,k,dem);
	}
	else
	{
		int dem=16;
		string newA=useinitialpermutation(A,IIP);	  
		string left = newA.substr(0, 32); 
		string right = newA.substr(32, 32);
		k=usePC1(k,pc1);
				xuat(k); 

		giaima(IP, IIP,pc1,pc2,Per,E,sbox,right,left,out,k,dem);
 
	}
    
}
void sinhK(string k,int dem,int yeucau,string &GhepK){
	string K1;
	string lK = k.substr(0, 28); 
	string rK = k.substr(28, 28);
	string LK ;
	string RK ;
	if(dem==1||dem==2||dem==9||dem==16)
	{

		LK =LCS(lK);

		RK =LCS(rK);
		}
	else
	{

		LK =LCS2(lK);
		
		RK =LCS2(rK);

	}
			GhepK=LK+RK;


	if(dem<yeucau){
		sinhK(GhepK,dem+1,yeucau,K1);

	}
	else{
			xuat(GhepK);
	}
	
}


void mahoa(int IP[],int IIP[],int pc1[],int pc2[],int per[],int E[],int sbox[][4][16],string rA,string lA,string out,string K,int dem)
{
	
	string lK = K.substr(0, 28); 
	string rK = K.substr(28, 28);
	
	string LK ;
	string RK ;
	if(dem==1||dem==2||dem==9||dem==16)
	{

		LK =LCS(lK);

		RK =LCS(rK);
		}
	else
	{

		LK =LCS2(lK);
		
		RK =LCS2(rK);

	}
	
	string GhepK=LK+RK;
	
	string KEY=usePC2(GhepK,pc2);
	
	string RA=useE(rA,E);
	string newRA=Xor(RA,KEY);
	newRA=Sbox(sbox,newRA);

	newRA=usePer(newRA,per);
	
	newRA=Xor(newRA,lA);
	
				cout<< "k"<<dem<<" : "<<GhepK<<"\n"; 

	if(dem<16)
	{

		mahoa(IP,IIP,pc1,pc2,per,E,sbox,newRA,rA,out,GhepK,dem+1);
	}
	else
	{	
		cout<<" K16 : "; 
		xuat(GhepK);	
		out=newRA+rA;
		out=useinitialpermutation(out,IIP);
		cout<<"CipherText : "; 
		xuat(out);
	}
	
}
void giaima(int IP[],int IIP[],int pc1[],int pc2[],int per[],int E[],int sbox[][4][16],string rA,string lA,string out,string K,int dem)
{

	string KEY=usePC2(K,pc2);

	string RA=useE(rA,E);
	string newRA=Xor(RA,KEY);
	newRA=Sbox(sbox,newRA);

	newRA=usePer(newRA,per);
	
	newRA=Xor(newRA,lA);
	
					cout<< "k"<<dem<<" : "<<K<<"\n"; 

	
	string lK = K.substr(0, 28); 
	string rK = K.substr(28, 28);
	
	string LK ;
	string RK ;
	if(dem==1||dem==2||dem==8||dem==16)
	{

		LK =RCS(lK);

		RK =RCS(rK);

		}
	else
	{
		LK =RCS2(lK);
		RK =RCS2(rK);

	}
	
	string GhepK=LK+RK;
	

	if(dem>1)
	{

		giaima(IP,IIP,pc1,pc2,per,E,sbox,newRA,rA,out,GhepK,dem-1);
	}
	else
	{	
		cout<< "k"<<dem<<" : "<<GhepK<<"\n"; 
		out=newRA+rA;
		out=useinitialpermutation(out,IP);
		cout<<"CipherText : "; 
		xuat(out);
	}
	
}
string Sbox(int sbox[][4][16],string newRA){
	int j=0;
	int a,b;
	string B="";
	for(int i=0;i<48;i++)
	{
		if(i%6==0)
		{
			string C="";
			string D="";
			for(int z=i+1;z<i+5;z++)
			{
				D+=newRA[z];							
			}
			C+=newRA[i];
			C+=newRA[i+5];
			 a=convertBinaryToDecimal(C);
			 b=convertBinaryToDecimal(D);
			B+=convertDecimalToBinary(sbox[j][a][b]);
			j++;
		}
	}
	return B;
}

string usePer(string A,int per[]){
	string B="";
	for(int i=0;i<48;i++)
	{
		B+=A[per[i]-1];
	}
	return B;
}

string useE(string A,int E[]){
	string B="";
	for(int i=0;i<48;i++)
	{
		B+=A[E[i]-1];
	}
	return B;
}

string usePC2(string K,int pc2[]){
	string B="";
	for(int i=0;i<48;i++)
	{
		B+=K[pc2[i]-1];
	}
	return B;
}

string usePC1(string K,int pc1[]){
	string B="";
	for(int i=0;i<56;i++)
	{
		B+=K[pc1[i]-1];
		
	}
	return B;
}





string useinitialpermutation(string A,int IP[])
{
	string B="";
	
	for(int i=0;i<64;i++)
	{
		B+=A[IP[i]-1];
		
	}
	return B;
}

string LCS(string A){
	string B="";
	for(int i=1;i<28;i++){
		B+=A[i];
	}	
	B+=A[0];
	return B;
}
string LCS2(string A){
	string B="";
	for(int i=2;i<28;i++){
		B+=A[i];
	}	
	B+=A[0];
	B+=A[1];
	return B;
}



string convertDecimalToBinary(int decimal)
{
	string binary;
    while(decimal != 0) {
		binary = (decimal % 2 == 0 ? "0" : "1") + binary; 
		decimal = decimal/2;
	}
	while(binary.length() < 4){
		binary = "0" + binary;
	}
    return binary;
}
int convertBinaryToDecimal(string binary)
{
    int decimal = 0;
	int counter = 0;
	int size = binary.length();
	for(int i = size-1; i >= 0; i--)
	{
    	if(binary[i] == '1'){
        	decimal += pow(2, counter);
    	}
    counter++;
	}
	return decimal;
}





string Xor(string a, string b){ 
	string result = ""; 
	int size = b.size();
	for(int i = 0; i < size; i++){ 
		if(a[i] != b[i]){ 
			result += "1"; 
		}
		else{ 
			result += "0"; 
		} 
	} 
	return result; 
} 

void  xuat( string A)
{
	for (int i=0;i<A.size();i++){
		cout<<A[i];	
	
	}
	cout<<"\n";
}
string RCS(string A){
	string B="";
	B+=A[27];
	for(int i=0;i<27;i++){
		B+=A[i];
	}	
	return B;
}
string RCS2(string A){
	string B="";
	B+=A[26];
	B+=A[27];
	for(int i=0;i<26;i++){
		B+=A[i];
	}	

	return B;
}

