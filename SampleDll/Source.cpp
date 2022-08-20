#include <Windows.h>
#include <filesystem>

DWORD __stdcall Thread(HINSTANCE thisModule)
{
    wchar_t filePath[MAX_PATH];
    GetModuleFileName(NULL, filePath, MAX_PATH);

    std::wstring message = L"It works! Hello from the sample dll!";
    std::wstring fileName = std::filesystem::path(filePath).stem();

    MessageBox(GetForegroundWindow(),(message + L"\n\nInjected to: " + fileName).c_str(), L"Hello", MB_OK | MB_ICONASTERISK);
    FreeLibraryAndExitThread(thisModule, 0);

    return 0;
}

BOOL __stdcall DllMain(HINSTANCE hinstDLL, DWORD fdwReason, LPVOID lpReserved)
{
    switch (fdwReason)
    {
    case DLL_PROCESS_ATTACH:
    {
        CreateThread(0, 0, (LPTHREAD_START_ROUTINE)Thread, hinstDLL, 0, 0);
        break;
    }
    case DLL_PROCESS_DETACH:
        break;
    }

    return TRUE;
}