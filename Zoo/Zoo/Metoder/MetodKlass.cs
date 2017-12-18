using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Models;


namespace Zoo.Metoder
{
    public class MetodKlass
    {
        public DjurAttUppdatera HämtaDjurFörUppdatering(int djurID)
        {
            DjurAttUppdatera djur = new DjurAttUppdatera();

            using (var db = new ZooContext())
            {
                var query = from p in db.Djur
                            join a in db.DjurArt on p.DjurArtID equals a.DjurArtID
                            join d in db.DjurTyp on p.DjurTypID equals d.DjurTypID
                            join c in db.Ursprungsland on p.UrsprungslandID equals c.UrsprungslandID
                            join e in db.Boendemiljö on p.BoendemiljöID equals e.BoendemiljöID
                            join f in db.Föräldrar on p.FöräldrarID equals f.FöräldrarID
                            where p.DjurID == djurID
                            select new DjurAttUppdatera
                            {
                                DjurID = p.DjurID,
                                Namnet = p.Namn,
                                Vikten = p.Vikt,
                                ArtID = a.DjurArtID,
                                TypID = d.DjurTypID,
                                LandID = c.UrsprungslandID,
                                MiljöID = e.BoendemiljöID,
                                MammaID = (int)f.MammaID,
                                PappaID = (int)f.PappaID
                            };

                foreach (var item in query)
                {
                    djur.DjurID = item.DjurID;
                    djur.Namnet = item.Namnet;
                    djur.Vikten = item.Vikten;
                    djur.TypID = item.TypID;
                    djur.ArtID = item.ArtID;
                    djur.MiljöID = item.MiljöID;
                    djur.LandID = item.LandID;
                    djur.MammaID = item.MammaID;
                    djur.PappaID = item.PappaID;
                }
                
            }

            return djur;
        }

        public bool UppdateraDjur(int djurid, string namn, float vikt, int artid, int typid, int miljöid, int landid, int mammaid, int pappaid)
        {
            using (var db = new ZooContext())
            {
                var djurAttUppdatera = db.Djur.Where(p => p.DjurID == djurid).FirstOrDefault();

                djurAttUppdatera.Namn = namn;
                djurAttUppdatera.Vikt = vikt;
                djurAttUppdatera.DjurArtID = artid;
                djurAttUppdatera.DjurTypID = typid;
                djurAttUppdatera.BoendemiljöID = miljöid;
                djurAttUppdatera.UrsprungslandID = landid;

                var föräldrarAttUppdatera = db.Föräldrar.Where(p => p.FöräldrarID == djurAttUppdatera.FöräldrarID).FirstOrDefault();
                föräldrarAttUppdatera.MammaID = mammaid;
                föräldrarAttUppdatera.PappaID = pappaid;

                if (djurAttUppdatera != null)
                {
                    db.SaveChanges();
                    return true;
                }
            }

            return false;
        }

        public bool RaderaDjur(int djurAttTaBortID)
        {
            using (var db = new ZooContext())
            {
                var djurAttTaBort = db.Djur.Where(p => p.DjurID == djurAttTaBortID).FirstOrDefault();

                if (djurAttTaBort != null)
                {
                    db.Djur.Remove(djurAttTaBort);
                    db.SaveChanges();

                    return true;
                }
            }

            return false;
        }

        public BindingList<Djuren> HämtaAllDjurInformation()
        {
            BindingList<Djuren> djur;

            using (var db = new ZooContext())
            {
                var query = from p in db.Djur
                            join a in db.DjurArt on p.DjurArtID equals a.DjurArtID
                            join d in db.DjurTyp on p.DjurTypID equals d.DjurTypID
                            join c in db.Ursprungsland on p.UrsprungslandID equals c.UrsprungslandID
                            join e in db.Boendemiljö on p.BoendemiljöID equals e.BoendemiljöID
                            join f in db.Föräldrar on p.FöräldrarID equals f.FöräldrarID
                            select new Djuren
                            {
                                DjurID = p.DjurID,
                                Namnet = p.Namn,
                                Vikten = p.Vikt,
                                DjurArten = a.Benämning,
                                DjurTypen = d.Benämning,
                                Ursprungslandet = c.Benämning,
                                Boendemiljön = e.Benämning,
                                Förälder1 = f.Djur1.Namn,
                                Förälder2 = f.Djur2.Namn
                            };

                djur = new BindingList<Djuren>(query.ToList());
            }

            return djur;
        }

        public BindingList<Arten> ArtInformation()
        {
            BindingList<Arten> arterna;

            using (var db = new ZooContext())
            {
                var query = from k in db.DjurArt
                            select new Arten
                            {
                                Benämning = k.Benämning,
                                ArtID = k.DjurArtID
                            };
                arterna = new BindingList<Arten>(query.ToList());
            }

            return arterna;
        }

        public BindingList<DjurTypen> DjurTypInformation()
        {
            BindingList<DjurTypen> djurTyper;

            using (var db = new ZooContext())
            {
                var query = from k in db.DjurTyp
                            select new DjurTypen
                            {
                                Benämning = k.Benämning,
                                TypID = k.DjurTypID
                            };
                djurTyper = new BindingList<DjurTypen>(query.ToList());
            }

            return djurTyper;
        }

        public BindingList<Miljön> BoendeMiljöInformation()
        {
            BindingList<Miljön> miiljöer;

            using (var db = new ZooContext())
            {
                var query = from k in db.Boendemiljö
                            select new Miljön
                            {
                                MiljöBenämning = k.Benämning,
                                MiljöID = k.BoendemiljöID
                            };
                miiljöer = new BindingList<Miljön>(query.ToList());
            }

            return miiljöer;
        }

        public BindingList<Landet> UrsprungslandInformation()
        {
            BindingList<Landet> länder;

            using (var db = new ZooContext())
            {
                var query = from k in db.Ursprungsland
                            select new Landet
                            {
                                Benmämning = k.Benämning,
                                LandID = k.UrsprungslandID
                            };
                länder = new BindingList<Landet>(query.ToList());
            }
            return länder;
        }

        public bool SkapaDjur(Djur djurAttLäggaTill, Föräldrar föräldrarAttLäggaTill)
        {
            using (var db = new ZooContext())
            {
                db.Föräldrar.Add(föräldrarAttLäggaTill);
                db.SaveChanges();
                var senastSkapadeFöräldrarID = db.Föräldrar.Where(p => p.FöräldrarID == föräldrarAttLäggaTill.FöräldrarID).First();
                djurAttLäggaTill.FöräldrarID = senastSkapadeFöräldrarID.FöräldrarID;

                var query = db.Djur.Where(p => p.DjurID == djurAttLäggaTill.DjurID).FirstOrDefault();
                db.Djur.Add(djurAttLäggaTill);
                db.SaveChanges();

                var id = djurAttLäggaTill.DjurID;

                if (id > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public BindingList<Djuren> Sortera(int miljöId, int artId, int typId)
        {
            BindingList<Djuren> sorteradeDjur = new BindingList<Djuren>();
            BindingList<Djuren> miljöDjur = new BindingList<Djuren>();
            BindingList<Djuren> artDjur = new BindingList<Djuren>();
            BindingList<Djuren> typDjur = new BindingList<Djuren>();

            var miljö = "";
            var art = "";
            var typ = "";

            using (var db = new ZooContext())
            {
                if (miljöId >= 1)
                {
                    var miljöQuery = from p in db.Djur
                                     join a in db.DjurArt on p.DjurArtID equals a.DjurArtID
                                     join d in db.DjurTyp on p.DjurTypID equals d.DjurTypID
                                     join c in db.Ursprungsland on p.UrsprungslandID equals c.UrsprungslandID
                                     join e in db.Boendemiljö on p.BoendemiljöID equals e.BoendemiljöID
                                     join f in db.Föräldrar on p.FöräldrarID equals f.FöräldrarID
                                     where p.BoendemiljöID == miljöId
                                     select new Djuren
                                     {
                                         DjurID = p.DjurID,
                                         Namnet = p.Namn,
                                         Vikten = p.Vikt,
                                         DjurArten = a.Benämning,
                                         DjurTypen = d.Benämning,
                                         Ursprungslandet = c.Benämning,
                                         Boendemiljön = e.Benämning,
                                         Förälder1 = f.Djur1.Namn,
                                         Förälder2 = f.Djur2.Namn
                                     };

                    foreach (var item in miljöQuery)
                    {
                        miljöDjur.Add(item);
                        miljö = item.Boendemiljön;
                    }
                }

                if (typId >= 1)
                {
                    var typIdQuery = from p in db.Djur
                                     join a in db.DjurArt on p.DjurArtID equals a.DjurArtID
                                     join d in db.DjurTyp on p.DjurTypID equals d.DjurTypID
                                     join c in db.Ursprungsland on p.UrsprungslandID equals c.UrsprungslandID
                                     join e in db.Boendemiljö on p.BoendemiljöID equals e.BoendemiljöID
                                     join f in db.Föräldrar on p.FöräldrarID equals f.FöräldrarID
                                     where p.DjurTypID == typId
                                     select new Djuren
                                     {
                                         DjurID = p.DjurID,
                                         Namnet = p.Namn,
                                         Vikten = p.Vikt,
                                         DjurArten = a.Benämning,
                                         DjurTypen = d.Benämning,
                                         Ursprungslandet = c.Benämning,
                                         Boendemiljön = e.Benämning,
                                         Förälder1 = f.Djur1.Namn,
                                         Förälder2 = f.Djur2.Namn,
                                     };

                    foreach (var item in typIdQuery)
                    {
                        typDjur.Add(item);
                        typ = item.DjurTypen;
                    }
                }

                if (artId >= 1)
                {
                    var artQuery = from p in db.Djur
                                   join a in db.DjurArt on p.DjurArtID equals a.DjurArtID
                                   join d in db.DjurTyp on p.DjurTypID equals d.DjurTypID
                                   join c in db.Ursprungsland on p.UrsprungslandID equals c.UrsprungslandID
                                   join e in db.Boendemiljö on p.BoendemiljöID equals e.BoendemiljöID
                                   join f in db.Föräldrar on p.FöräldrarID equals f.FöräldrarID
                                   where p.DjurArtID == artId
                                   select new Djuren
                                   {
                                       DjurID = p.DjurID,
                                       Namnet = p.Namn,
                                       Vikten = p.Vikt,
                                       DjurArten = a.Benämning,
                                       DjurTypen = d.Benämning,
                                       Ursprungslandet = c.Benämning,
                                       Boendemiljön = e.Benämning,
                                       Förälder1 = f.Djur1.Namn,
                                       Förälder2 = f.Djur2.Namn
                                   };

                    foreach (var item in artQuery)
                    {
                        artDjur.Add(item);
                        art = item.DjurArten;
                    }
                }
            };

            bool miljöBool = true;
            bool typBool = true;
            bool artBool = true;
            bool finnsInte = true;

            foreach (var item in miljöDjur)
            {
                typBool = true;
                artBool = true;
                finnsInte = true;

                if (art != "")
                {
                    if (item.DjurArten != art)
                    {
                        artBool = false;
                    }
                }

                if (typ != "")
                {
                    if (item.DjurTypen != typ)
                    {
                        typBool = false;
                    }
                }

                foreach (var existerandeDjur in sorteradeDjur.ToList())
                {
                    if (item.DjurID == existerandeDjur.DjurID)
                    {
                        finnsInte = false;
                    }
                }

                if (typBool && artBool && finnsInte)
                {
                    sorteradeDjur.Add(item);
                }
            }

            foreach (var item in typDjur)
            {
                miljöBool = true;
                artBool = true;
                finnsInte = true;

                if (miljö != "")
                {
                    if (item.Boendemiljön != miljö)
                    {
                        miljöBool = false;
                    }
                }

                if (art != "")
                {
                    if (item.DjurArten != art)
                    {
                        artBool = false;
                    }
                }

                foreach (var existerandeDjur in sorteradeDjur.ToList())
                {
                    if (item.DjurID == existerandeDjur.DjurID)
                    {
                        finnsInte = false;
                    }
                }

                if (finnsInte && artBool && miljöBool)
                {
                    sorteradeDjur.Add(item);
                }
            }

            foreach (var item in artDjur)
            {
                miljöBool = true;
                typBool = true;
                finnsInte = true;

                if (miljö != "")
                {
                    if (item.Boendemiljön != miljö)
                    {
                        miljöBool = false;
                    }
                }

                if (typ != "")
                {
                    if (item.DjurTypen != typ)
                    {
                        typBool = false;
                    }
                }

                foreach (var existerandeDjur in sorteradeDjur.ToList())
                {
                    if (item.DjurID == existerandeDjur.DjurID)
                    {
                        finnsInte = false;
                    }
                }

                if (finnsInte && typBool && miljöBool)
                {
                    sorteradeDjur.Add(item);
                }
            }

            return sorteradeDjur;
        }
    }

    public class VeterinärMetoderna
    {
        public bool SkapaBesök(int djurID, TimeSpan tid, DateTime datum, int veterinärID)
        {
            using (var db = new ZooContext())
            {
                BesökHosVeterinär bokatBesök = new BesökHosVeterinär();
                bokatBesök.DjurID = djurID;
                bokatBesök.VeterinärID = veterinärID;
                bokatBesök.TidFörBesök = tid;
                bokatBesök.DatumförBesök = datum;

                db.BesökHosVeterinär.Add(bokatBesök);
                db.SaveChanges();

                if (bokatBesök.ID > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public BindingList<Veterinären> VeterinärInformation()
        {
            BindingList<Veterinären> veterinärer;

            using (var db = new ZooContext())
            {
                var query = from k in db.Veterinär
                            select new Veterinären
                            {
                                Namn = k.Namn,
                                ID = k.VeterinärID
                            };
                veterinärer = new BindingList<Veterinären>(query.ToList());
            }

            return veterinärer;
        }

        public BindingList<BokadeBesök> HämtaBokningar(int djurID)
        {
            BindingList<BokadeBesök> bokadeBesök;

            using (var db = new ZooContext())
            {
                var query = from k in db.BesökHosVeterinär
                            join p in db.Veterinär on k.VeterinärID equals p.VeterinärID
                            where k.DjurID == djurID
                            select new BokadeBesök
                            {
                                besökID = k.ID,
                                djurid = djurID,
                                veterinärNamn = p.Namn,
                                Tid = (TimeSpan)k.TidFörBesök,
                                Datum = (DateTime)k.DatumförBesök
                            };

                bokadeBesök = new BindingList<BokadeBesök>(query.ToList());
            }

            return bokadeBesök;
        }

        public bool RaderaBokning(int bokningsID)
        {
            using (var db = new ZooContext())
            {
                var bokningAttTaBort = db.BesökHosVeterinär.Where(p => p.ID == bokningsID).FirstOrDefault();

                if (bokningAttTaBort != null)
                {
                    db.BesökHosVeterinär.Remove(bokningAttTaBort);
                    db.SaveChanges();

                    return true;
                }
            }

            return false;
        }

        public bool BestämdDiagnosFörBokning(int bokningsID, string diagnosNamn)
        {
            using (var db = new ZooContext())
            {
                Diagnos nyDiagnos = new Diagnos();
                nyDiagnos.Namn = diagnosNamn;

                db.Diagnos.Add(nyDiagnos);
                db.SaveChanges();
                
                BesökHosVeterinär besök = db.BesökHosVeterinär.Where(p => p.ID == bokningsID).FirstOrDefault();
                besök.DiagnosID = nyDiagnos.DiagnosID;
                db.SaveChanges();

                if (besök.ID > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool NyDiagnos(string beskrivning, string namn)
        {
            using (var db = new ZooContext())
            {
                Diagnos nyDiag = new Diagnos();

                nyDiag.Beskrivning = beskrivning;
                nyDiag.Namn = namn;

                db.Diagnos.Add(nyDiag);
                db.SaveChanges();

                var nyttID = nyDiag.DiagnosID;

                if (nyDiag.DiagnosID > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public BindingList<Diganos> HämtaDiagnoser()
        {
            BindingList<Diganos> diagnoser;

            using (var db = new ZooContext())
            {
                var query = from k in db.Diagnos
                            select new Diganos
                            {
                                Namn = k.Namn,
                                ID = k.DiagnosID
                            };

                diagnoser = new BindingList<Diganos>(query.ToList());
            }
            return diagnoser;
        }

        public BindingList<Medicinen> HämtaAllaMediciner()
        {
            BindingList<Medicinen> mediciner = new BindingList<Medicinen>();

            using (var db = new ZooContext())
            {
                var query = from k in db.MedicinTillDiagnos
                            select new Medicinen
                            {
                                Namn = k.Benämning,
                                ID = k.ID,
                            };

                mediciner = new BindingList<Medicinen> (query.ToList());         
            }

            return mediciner;
        }

        public bool SkapaNyMedicin(string namn)
        {
            using (var db = new ZooContext())
            {
                MedicinTillDiagnos nyMed = new MedicinTillDiagnos();

                nyMed.Benämning = namn;

                db.MedicinTillDiagnos.Add(nyMed);
                db.SaveChanges();

                var nyttID = nyMed.DiagnosID;

                if (nyMed.DiagnosID > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public BindingList<Medicinen> LäggMedicinerTillDatagriden(int medincinId)
        {
            BindingList<Medicinen> mediciner;

            using (var db = new ZooContext())
            {
                var query = from k in db.MedicinTillDiagnos
                            where k.ID == medincinId
                            select new Medicinen
                            {
                                Namn = k.Benämning,
                                ID = k.ID,
                            };

                mediciner = new BindingList<Medicinen>(query.ToList());
            }
            return mediciner;
        }

        public void SparaMedicinernaTillistan ()
        {
            using (var db = new ZooContext())
            {
                db.SaveChanges();
            }
        }

        public bool RegistreraKlartBesökMedMedicinListaTillDiagnos(int diagnosId, int MedicinID, string medNamn)
        {
            using (var db = new ZooContext())
            {
                MedicinTillDiagnos nyMed = new MedicinTillDiagnos();
                nyMed.ID = MedicinID;
                nyMed.DiagnosID = diagnosId;
                nyMed.Benämning = medNamn;

                db.MedicinTillDiagnos.Add(nyMed);

                var nyttID = nyMed.ID;

                if (nyMed.ID > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}

