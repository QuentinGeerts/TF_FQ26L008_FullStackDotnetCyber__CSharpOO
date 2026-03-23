namespace DemoGenericite.Interfaces;

internal interface IConvertisseur<TEntree, TSortie>
{
    TSortie Convertir(TEntree value);
}
