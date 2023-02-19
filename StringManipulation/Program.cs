using StringManipulation;

string encoded = Helper.Encode("African Journal");
string decoded = Helper.Decode(encoded);

// Print the original and decoded strings
Console.WriteLine("Original: " + "African Journal");
Console.WriteLine("Decoded: " + decoded);

