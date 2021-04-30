﻿/*
 * when a client arrives at a star he requests the current storages from all ILS in that system
 * this will also sync the belt filters
 * this will help to give the impression of alive factories
 */
namespace NebulaModel.Packets.Logistics
{
    public class ILSArriveStarPlanetRequest
    {
        public int starId { get; set; }
        public int planetId { get; set; }
        public ILSArriveStarPlanetRequest() { }
        public ILSArriveStarPlanetRequest(int starId, int planetId)
        {
            this.starId = starId;
        }
    }
}
