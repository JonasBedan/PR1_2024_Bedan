using System;

class MainClass
{
    public static void Main(string[] args)
    {
        // sem přijde váš kód
        Console.Write("napiš v jakém roce ses narodil:");
        int rokNarozeni = int.Parse(Console.ReadLine());

        int vekDuchodu = rokNarozeni switch
        {
            1936 or 1937 or 1938 or 1939 or 1940 => 60,
            1941 or 1942 or 1943 or 1944 or 1945 or 1946 => 61,
            1947 or 1948 or 1949 or 1950 or 1951 or 1952 => 62,
            1953 or 1954 or 1955 or 1956 or 1957 or 1958 => 63,
            1959 or 1960 or 1961 or 1962 or 1963 or 1964 => 64,
            1965 or 1966 or 1967 or 1968 or 1969 or 1970 => 65,
            1971 or 1972 or 1973 or 1974 or 1975 or 1976 => 66,
            1977 or 1978 or 1979 or 1980 or 1981 or 1982 => 67,
            1983 or 1984 or 1985 or 1986 or 1987 or 1988 => 68,
            1989 or 1990 or 1991 or 1992 or 1993 or 1994 => 69,
            1995 or 1996 or 1997 or 1998 or 1999 or 2000 => 70,
            2001 or 2002 or 2003 or 2004 or 2005 => 71,
            2006 or 2007 or 2008 or 2009 or 2010 or 2011 or 2012 or 2013 or 2014 or 2015 or 2016 or 2017 or 2018 or 2019 or 2020 or 2021 or 2022 => 72,
        };
        Console.WriteLine("do důchodu půjdeš v roce "+(rokNarozeni+vekDuchodu)+" a bude ti "+vekDuchodu);
    }
}