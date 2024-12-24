using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace BW {

    public class FlagRepository {

        Dictionary<int, FlagEntity> all;

        FlagEntity[] temArray;

        public FlagRepository() {
            all = new Dictionary<int, FlagEntity>();
            temArray = new FlagEntity[100];
        }

        public void Add(FlagEntity entity) {
            all.Add(entity.idSig, entity);
        }

        public void Remove(FlagEntity entity) {
            all.Remove(entity.idSig);
        }

        public int TakeAll(out FlagEntity[] array) {
            if (all.Count > temArray.Length) {
                temArray = new FlagEntity[all.Count * 2];
            }
            all.Values.CopyTo(temArray, 0);
            array = temArray;
            return all.Count;
        }

        public bool TryGet(int idSig, out FlagEntity entity) {
            return all.TryGetValue(idSig, out entity);
        }

        public void Clear() {
            all.Clear();
        }
    }
}