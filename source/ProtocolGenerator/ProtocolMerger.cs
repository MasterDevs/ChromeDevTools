using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterDevs.ChromeDevTools.ProtocolGenerator
{
    class ProtocolMerger
    {
        public static void Merge(Protocol source, Protocol target)
        {
            foreach (var domain in source.Domains)
            {
                if (!target.Domains.Contains(domain, NameEqualityComparer<Domain>.Instance))
                {
                    target.Domains.Add(domain);
                }
                else
                {
                    Merge(source, domain, target.Domains.Single(t => NameEqualityComparer<Domain>.Instance.Equals(domain, t)));
                }
            }
        }

        static void Merge(Protocol protocol, Domain source, Domain target)
        {
            Merge(protocol, source, source.Commands, target.Commands);
            Merge(protocol, source, source.Events, target.Events);
            Merge(protocol, source, source.Types, target.Types);
        }

        static void Merge<T>(Protocol protocol, Domain domain, Collection<T> source, Collection<T> target)
            where T : ProtocolItem
        {
            foreach (var item in source)
            {
                if (!target.Contains(item, NameEqualityComparer<T>.Instance))
                {
                    target.Add(item);
                }
                else
                {
                    var targetItem = target.Single(t => NameEqualityComparer<T>.Instance.Equals(item, t));

                    if (!targetItem.Equals(item))
                    {
                        Console.WriteLine($"{protocol.Alias};{domain.Name};{item.Name};{item};{targetItem};{typeof(T).Name}");
                    }
                    else
                    {
                        foreach (var v in item.SupportedBy)
                        {
                            targetItem.SupportedBy.Add(v);
                        }
                    }
                }
            }
        }
    }
}
