using System.Linq;
using Riok.Mapperly.Abstractions;

namespace MapperlyV3Repro;

[Mapper]
public partial class InstanceMapper
{
    public partial D Map(A source);
    public partial IQueryable<D> Map(IQueryable<A> source);

    public E Map(B source)
        => Map(source.Child);

    public partial E Map(C source);
}

public record class A(B Value);
public record class B(C Child);
public record class C(string Name);

public record class D(E Value);
public record class E(string Name);