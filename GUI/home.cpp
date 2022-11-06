#include "home.h"
#include <Windows.h>
using namespace BIS;


int WINAPI WinMain(HINSTANCE, HINSTANCE, LPSTR, int)
{
	Application::EnableVisualStyles();
	Application::SetCompatibleTextRenderingDefault(false);
	Application::Run(gcnew addbook());
	return 0;

};




