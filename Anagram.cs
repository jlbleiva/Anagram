using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

public class Anagram
{
    private string initialWord;

    //el constructor devuelve la palabra en minusculas
    public Anagram(string word) => this.initialWord = word.ToLower();
    
    //aqui lo que hace es ir devolviendo cadenas que no es la misma word, y comprueba si la palabra de la lista
    //ordenada por caracteres y en minusculas es distinta a la word base ordenada por caracteres, si es distinta es un
    //anagrama
    public string[] FindAnagrams(string[] potentialMatches)
        => potentialMatches
            .Where(item => item.ToLower().OrderBy(x => x)
                               .SequenceEqual(initialWord.OrderBy(x => x))
                           && item.ToLower() != initialWord).ToArray();
}
            

    
    