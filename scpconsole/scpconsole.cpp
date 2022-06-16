// scpconsole.cpp : 此文件包含 "main" 函数。程序执行将在此处开始并结束。
//

#include <iostream>

#import "scpdll.tlb" raw_interfaces_only
using namespace scpdll;
int main()
{
	
	
	HRESULT hr = CoInitialize(nullptr);

	// Create the interface pointer.
	Interface1* interface1r = nullptr;
	hr = CoCreateInstance(__uuidof(Class1), nullptr, CLSCTX_INPROC_SERVER, __uuidof(Interface1), (void**)&interface1r);

	//long result = 0;
	VARIANT_BOOL result_bool;
	interface1r->plugin_Click(1);
	
	//interface1r->btnA_Click(&result_bool);
	//printf("result_bool:%d\n", result_bool);
	for (size_t i = 0; i < 20; i++)
	{
		Sleep(1000);
		interface1r->btnXbox_Click(&result_bool);
		//interface1r->btnXbox_Click(&result_bool);
		printf("result_bool:%d\n", result_bool);
	}
	

	

	Sleep(1000);
	interface1r->unplugAll_Click();
	//interface1r->unplug_Click();
		/*
		 void plugin_Click(int index);
         bool btnA_Click();*/

}

