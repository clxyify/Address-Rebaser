//This was orignally a private Rebaser I developed for roblox exploiting, so I used my code for this cpp file.

#define ASLR(x)(x - 0x400000 + (DWORD)GetModuleHandleA(0))// Address space layout randomization (ASLR) 

std::cout << "Here's your Address:";
printf("0x");//Add a good format
printf("%X", 0x333F230 - 0x400000);//convert 0x333F230 into decimal and 0x400000 into a decimal then subtract
//0x333F230 is your address! replace that with your whatever address to rebase.
