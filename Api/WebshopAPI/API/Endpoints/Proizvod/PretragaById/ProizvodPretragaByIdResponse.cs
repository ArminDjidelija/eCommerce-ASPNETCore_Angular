﻿namespace WebAPI.Endpoints.Proizvod.PretragaById
{
    public class ProizvodPretragaByIdResponse
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public int PocetnaKolicina { get; set; } = 0;
        public float PocetnaCijena { get; set; }
        public float Popust { get; set; }
        public string Opis { get; set; }
        public int BrojKlikova { get; set; } = 0;

        public string PotkategorijaNaziv { get; set; }
        public int PotkategorijaID { get; set; }
        public string BrendNaziv { get; set; }
        public int BrendID { get; set; }
        public string SlikaUrl { get; set; }
        public List<string> SlikeGalerija { get; set; }
    }
}
