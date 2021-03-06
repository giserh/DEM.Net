﻿// BeanTopologieFacettes.cs
//
// Author:
//       Frédéric Aubin
//
// Copyright (c) 2019 
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEM.Net.Core.Services.Lab
{
    public class BeanTopologieFacettes
    {
        public List<BeanPoint_internal> p00_pointsSources { get; set; }
        //
        public Dictionary<int, BeanPoint_internal> p11_pointsFacettesByIdPoint { get; set; }
        public Dictionary<string, BeanPoint_internal> p11_pointsFacettesByCode { get; set; }

        public Dictionary<string, BeanArc_internal> p12_arcsByCode { get; set; }
        public Dictionary<int, BeanFacette_internal> p13_facettesById { get; set; }
          //
        public BeanFacette_internal p21_facetteAvecEcartAbsoluMax { get; set; }
        
        
        //Services ajout suppression: 
        //!!ATTENTION: tous les services de propagation et de contrôle ne sont pas implémentés!!
        public void ArcsAjouter(IEnumerable<BeanArc_internal> p_arcsAAjouter)
        {
            foreach(BeanArc_internal v_arc in p_arcsAAjouter)
            {
                ArcAjouter(v_arc);
            }
        }
        public void ArcAjouter(BeanArc_internal p_arcAAjouter)
        {
            //if (!p11_pointsFacettesByCode.ContainsKey(p_arcAAjouter.p11_pointDbt.p01_hCodeGeog))
            if(!p11_pointsFacettesByIdPoint.ContainsKey(p_arcAAjouter.p11_pointDbt.p00_id))
            {
                p11_pointsFacettesByIdPoint.Add(p_arcAAjouter.p11_pointDbt.p00_id, p_arcAAjouter.p11_pointDbt);
                p11_pointsFacettesByCode.Add(p_arcAAjouter.p11_pointDbt.p01_hCodeGeog, p_arcAAjouter.p11_pointDbt);
            }

            //if (!p11_pointsFacettesByCode.ContainsKey(p_arcAAjouter.p12_pointFin.p01_hCodeGeog))
            if (!p11_pointsFacettesByIdPoint.ContainsKey(p_arcAAjouter.p12_pointFin.p00_id))
            {
                p11_pointsFacettesByIdPoint.Add(p_arcAAjouter.p12_pointFin.p00_id, p_arcAAjouter.p12_pointFin);
                p11_pointsFacettesByCode.Add(p_arcAAjouter.p12_pointFin.p01_hCodeGeog, p_arcAAjouter.p11_pointDbt);
            }
            //
            if(!p_arcAAjouter.p11_pointDbt.p41_arcsAssocies.ContainsKey(p_arcAAjouter.p01_hcodeArc))
            {
                p_arcAAjouter.p11_pointDbt.p41_arcsAssocies.Add(p_arcAAjouter.p01_hcodeArc, p_arcAAjouter);
            }
            p_arcAAjouter.p11_pointDbt.p43_ordonnancementOK_vf = false;
            if (!p_arcAAjouter.p12_pointFin.p41_arcsAssocies.ContainsKey(p_arcAAjouter.p01_hcodeArc))
            {
                p_arcAAjouter.p12_pointFin.p41_arcsAssocies.Add(p_arcAAjouter.p01_hcodeArc, p_arcAAjouter);
            }
            p_arcAAjouter.p12_pointFin.p43_ordonnancementOK_vf = false;
            //
            if(!p12_arcsByCode.ContainsKey(p_arcAAjouter.p01_hcodeArc))
            {
                p12_arcsByCode.Add(p_arcAAjouter.p01_hcodeArc, p_arcAAjouter);
            }
        }
        public void ArcSupprimer(BeanArc_internal p_arcASupprimer)
        {
            p11_pointsFacettesByIdPoint[p_arcASupprimer.p11_pointDbt.p00_id].p41_arcsAssocies.Remove(p_arcASupprimer.p01_hcodeArc);
            p11_pointsFacettesByIdPoint[p_arcASupprimer.p12_pointFin.p00_id].p41_arcsAssocies.Remove(p_arcASupprimer.p01_hcodeArc);   
            //
          
               //ATTENTION: services sur les facettes non implémentés à ce stade!!
                //La suppression doit amener la création d'une nouvelle facette.
                //La suppression d'un "arc base" devrait amener à passer les arcs de la facette correspondante en "base"
           
            //
            p12_arcsByCode.Remove(p_arcASupprimer.p01_hcodeArc);      
        }

        public void ArcSupprimer(string p_codeArcASupprimer)
        {
            BeanArc_internal v_arcASupprimer = p12_arcsByCode[p_codeArcASupprimer];
            ArcSupprimer(v_arcASupprimer);
        }
        //
        public void PointFacAjouter(BeanPoint_internal p_pointAAjouter)
        {
            if(!p11_pointsFacettesByIdPoint.ContainsKey(p_pointAAjouter.p00_id))
            {
                p11_pointsFacettesByIdPoint.Add(p_pointAAjouter.p00_id, p_pointAAjouter);
            }
          
        }
        public void PointsFacAjouter(List<BeanPoint_internal> p_pointsAAjouter)
        {
            foreach (BeanPoint_internal v_point in p_pointsAAjouter)
            {
                PointFacAjouter(v_point);
            }
        }
        //On ne prévoit pas, à ce stade, de suppression de points facettes

        public void FacetteAjouter(BeanFacette_internal p_facetteAAjouter)
        {
            //On n'effectue aucun contrôle de cohérence ?
            p13_facettesById.Add(p_facetteAAjouter.p00_idFacette, p_facetteAAjouter);
        }
        public void FacettesAjouter(IEnumerable<BeanFacette_internal> p_facetteAAjouter)
        {
            foreach(BeanFacette_internal v_fac in p_facetteAAjouter)
            {
                FacetteAjouter(v_fac);
            }
        }
        public void FacetteSupprimer(BeanFacette_internal p_facetteASupprimer)
        {
            //On n'effectue aucun contrôle de cohérence ...
            FacetteSupprimer(p_facetteASupprimer.p00_idFacette);
        }
        public void FacetteSupprimer(int p_idFacetteASupprimer)
        {
            //On n'effectue aucun contrôle de cohérence ...
            if(!p13_facettesById.ContainsKey(p_idFacetteASupprimer))
            {
                return;
            }
     
            BeanFacette_internal v_facetteASupprimer = p13_facettesById[p_idFacetteASupprimer];
            //
            if (v_facetteASupprimer.p23_facetteEcartSup != null)
            {
                v_facetteASupprimer.p23_facetteEcartSup.p24_facetteEcartInf = v_facetteASupprimer.p24_facetteEcartInf;
            }

            if (v_facetteASupprimer.p24_facetteEcartInf != null)
            {
                v_facetteASupprimer.p24_facetteEcartInf.p23_facetteEcartSup = v_facetteASupprimer.p23_facetteEcartSup; //(Qui peut être nulle)
            }
            if (p21_facetteAvecEcartAbsoluMax == v_facetteASupprimer) //(La facette à supprimer était la 'première'
            {
                p21_facetteAvecEcartAbsoluMax = v_facetteASupprimer.p24_facetteEcartInf;
            }

            //
            p13_facettesById.Remove(p_idFacetteASupprimer);
        }

        public BeanTopologieFacettes()
        {
            p11_pointsFacettesByIdPoint = new Dictionary<int, BeanPoint_internal>();
            p11_pointsFacettesByCode = new Dictionary<string, BeanPoint_internal>();
            p12_arcsByCode = new Dictionary<string, BeanArc_internal>();
            p13_facettesById = new Dictionary<int, BeanFacette_internal>();
            p21_facetteAvecEcartAbsoluMax = null;
        }
        public BeanTopologieFacettes(List<BeanPoint_internal> p_pointsSources):this()
        {
            p00_pointsSources = p_pointsSources;
        }
        public BeanTopologieFacettes(List<BeanArc_internal> p_arcs):this()
        {
            foreach(BeanArc_internal v_arc in p_arcs)
            {
                this.ArcAjouter(v_arc);
            }
           
        }

    }
}
