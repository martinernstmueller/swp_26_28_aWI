Console.Write("Bitte einen String eingeben: ");
string eingabe = Console.ReadLine();

if (eingabe != null)
{
    // 1. Versuche, die Eingabe als Ganzzahl (int) zu interpretieren
    if (int.TryParse(eingabe, out int intWert))
    {
        Console.WriteLine($"Erkannt: Integer (Ganzzahl) -> {intWert}");
        return;
    }
    // 2. Versuche, die Eingabe als Kommazahl (double) zu interpretieren
    if (double.TryParse(eingabe, out double doubleWert))
    {
        Console.WriteLine($"Erkannt: Rationale Zahl (Double) -> {doubleWert}");
        return;
    }
    // 3. Versuche, die Eingabe als Wahrheitswert (bool) zu interpretieren
    if (bool.TryParse(eingabe, out bool boolWert))
    {
        Console.WriteLine($"Erkannt: Boolean (Wahrheitswert) -> {boolWert}");
        return;
    }
    // 4. Wenn nichts davon zutrifft, bleibt es ein String
    Console.WriteLine($"Erkannt: Regulärer String (Text) -> {eingabe}");

    Console.ReadKey();
}