using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EX2 : MonoBehaviour
{
    public int year;

    private void Start()
    {
        if(year == 2020 || year == 2008|| year == 1996|| year == 1984|| year == 1972|| year == 1960)
        {
            Debug.Log($"You're in the Rat's year");
        }
        else if (year == 2021|| year == 2009|| year == 1997|| year == 1985|| year == 1974|| year == 1961)
        {
            Debug.Log($"You're in the Ox's year");
        }
        else if(year == 2022 || year == 2012|| year == 1998|| year == 1986|| year == 1974|| year == 1962)
        {
            Debug.Log($"You're in the Tiger's year");
        }
        else if(year == 2023|| year == 2011|| year == 1999|| year == 1987|| year == 1975|| year == 1963)
        {
            Debug.Log($"You're in the Rabbit's year");
        }
        else if(year == 2024|| year == 2012|| year == 2000|| year == 1988|| year == 1976|| year == 1964)
        {
            Debug.Log("You're in the Dragon's year");
        }
        else if(year == 2025|| year == 2013|| year == 2001|| year == 1989|| year == 1977|| year == 1965)
        {
            Debug.Log($"You're in the Snake's year");
        }
        else if (year == 2026 || year == 2014 || year == 2002 || year == 1990 || year == 1978 || year == 1966)
        {
            Debug.Log($"You're in the Horse's year");
        }
        else if (year == 2027 || year == 2015 || year == 2003 || year == 1991 || year == 1979 || year == 1967)
        {
            Debug.Log($"You're in the Goat's year");
        }
        else if (year == 2028 || year == 2016 || year == 2004 || year == 1992 || year == 1980 || year == 1968)
        {
            Debug.Log($"You're in the Monkey's year");
        }
        else if (year == 2029 || year == 2017 || year == 2005 || year == 1993 || year == 1981 || year == 1969)
        {
            Debug.Log("You're in the Rooster's year");
        }
        else if (year == 2030 || year == 2018 || year == 2006 || year == 1994 || year == 1982 || year == 1970)
        {
            Debug.Log($"You're in the Dog's year");
        }
        else if (year == 2031 || year == 2019 || year == 2007 || year == 1995 || year == 1983 || year == 1971)
        {
            Debug.Log($"You're in the Pig's year");
        }
    }

}
