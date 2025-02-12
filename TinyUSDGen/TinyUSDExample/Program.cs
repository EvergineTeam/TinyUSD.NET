using Evergine.Bindings.TinyUSD;

string path = "../../../resources/output.usda";
IntPtr stage = TinyUSDNative.c_tinyusd_stage_new();
IntPtr warn = TinyUSDNative.c_tinyusd_string_new_empty();
IntPtr err = TinyUSDNative.c_tinyusd_string_new_empty();
IntPtr str = TinyUSDNative.c_tinyusd_string_new_empty();

int ret = TinyUSDNative.c_tinyusd_load_usd_from_file(path, stage, warn, err);

if (TinyUSDNative.c_tinyusd_string_size(warn) == 1)
{
    Console.WriteLine("WARN: {0}\n", TinyUSDNative.c_tinyusd_string_str(warn));
}

if (ret == 1)
{
    str = TinyUSDNative.c_tinyusd_string_new_empty();

    if (TinyUSDNative.c_tinyusd_stage_to_string(stage, str) == 0)
    {
        Console.WriteLine("Unexpected error when exporting Stage to string.\n");
        return;
    }

    string resultStr = TinyUSDNative.c_tinyusd_string_str(str);
    Console.WriteLine(resultStr);
}
else
{
    Console.WriteLine("ERROR: {0}\n", TinyUSDNative.c_tinyusd_string_str(err));
}

//
// Release resources.
//

if (TinyUSDNative.c_tinyusd_string_free(str) == 0)
{
    Console.WriteLine("str string free failed.\n");
    return;
}

if (TinyUSDNative.c_tinyusd_stage_free(stage) == 0)
{
    Console.WriteLine("Stage free failed.\n");
    return;
}
if (TinyUSDNative.c_tinyusd_string_free(warn) == 0)
{
    Console.WriteLine("warn string free failed.\n");
    return;
}
if (TinyUSDNative.c_tinyusd_string_free(err) == 0)
{
    Console.WriteLine("err string free failed.\n");
    return;
}