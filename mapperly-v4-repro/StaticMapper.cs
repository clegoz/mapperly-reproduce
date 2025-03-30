using System.Linq;
using Riok.Mapperly.Abstractions;

namespace MapperlyV4Repro;

[Mapper]
public static partial class StaticMapper
{
    public static partial D Map(A source);
    public static partial IQueryable<D> Map(IQueryable<A> source);

    public static E Map(B source)
        => Map(source.Child);

    public static partial E Map(C source);
}

public record class A(B Value);
public record class B(C Child);
public record class C(string Name);

public record class D(E Value);
public record class E(string Name);