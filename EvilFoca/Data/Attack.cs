/* 
Evil FOCA
Copyright (C) 2015 ElevenPaths

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace evilfoca.Data
{
    public enum AttackType
    {
        NeighborAdvertisementSpoofing,
        ARPSpoofing,
        DNSHijacking,
        DHCPACKInjection,
        DHCPIpv6,
        DoSSLAAC,
        InvalidMacSpoofIpv4,
        SlaacMitm,
        WpadIPv4,
        WpadIPv6
    }

    public enum AttackStatus
    {
        Attacking,
        Stopping,
        Stop
    }

    public abstract class Attack
    {
        public AttackStatus attackStatus;
        public AttackType attackType;

        public Attack(AttackType attackType)
        {
            this.attackType = attackType;
            this.attackStatus = AttackStatus.Attacking;
        }

        public void Start()
        {
            this.attackStatus = AttackStatus.Attacking;
        }

        public void Pause()
        {
            this.attackStatus = AttackStatus.Stopping;
        }

    }
}
