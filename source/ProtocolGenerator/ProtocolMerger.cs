using System;
using System.Collections.Generic;
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
                if (!target.Domains.Contains(domain, NameEqualityComparer.Instance))
                {
                    target.Domains.Add(domain);
                }
                else
                {
                    Merge(domain, target.Domains.Single(t => NameEqualityComparer.Instance.Equals(domain, t)));
                }
            }
        }

        static void Merge(Domain source, Domain target)
        {
            foreach (var command in source.Commands)
            {
                if (!target.Commands.Contains(command, NameEqualityComparer.Instance))
                {
                    target.Commands.Add(command);
                }
                else
                {
                    var targetCommand = target.Commands.Single(t => NameEqualityComparer.Instance.Equals(command, t));

                    if(!targetCommand.Equals(command))
                    {
                        Console.WriteLine($"{source.Name}:{command},{targetCommand}");
                    }
                    else
                    {
                        foreach (var v in command.SupportedBy)
                        {
                            targetCommand.SupportedBy.Add(v);
                        }
                    }
                }
            }

            foreach (var @event in source.Events)
            {
                if (!target.Events.Contains(@event, NameEqualityComparer.Instance))
                {
                    target.Events.Add(@event);
                }
                else
                {
                }
            }

            foreach (var type in source.Types)
            {
                if (!target.Types.Contains(type, NameEqualityComparer.Instance))
                {
                    target.Types.Add(type);
                }
                else
                {
                }
            }
        }
    }
}
