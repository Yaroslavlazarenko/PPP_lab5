﻿using System.Reflection;
using System.Text;

namespace PPP_lab5
{
    public class Household
    {
        private Pets[] _pets;
        public Pets[] Pets  => _pets;

        public Household(params Pets[] pets)
        {
            _pets = pets;
        }

        /// <summary>
        /// Добавление питомца
        /// </summary>
        /// <param name="pet">Новый питомец</param>
        public void AddPet(Pets pet)
        {
            Array.Resize(ref _pets, _pets.Length + 1);
            _pets[^1] = pet;
        }

        /// <summary>
        /// Удаление питомца
        /// </summary>
        /// <param name="index">Индекс питомца в домашнем хозяйтсве </param>
        /// <exception cref="IndexOutOfRangeException">Индекс питомца которого следует удалить должен иметься в массиве питомцев</exception>
        public void RemovePet(int index)
        {
            if(index <0 || index >= _pets.Length)
            {
                throw new IndexOutOfRangeException();
            }

            for (int i = index; i < _pets.Length - 1; i++)
            {
                _pets[i] = _pets[i + 1];
            }
            Array.Resize(ref _pets, _pets.Length - 1);
        }

        /// <summary>
        /// Изменение информации питомца на новую
        /// </summary>
        /// <param name="index">Индекс питомца в домашнем хозяйтсве</param>
        /// <param name="newPetInfo">Новая информация про питомца</param>
        /// <exception cref="IndexOutOfRangeException">Индекс питомца которого следует удалить должен иметься в массиве питомцев</exception>
        public void EditPet(int index, Pets newPetInfo)
        {
            if (index < 0 || index >= _pets.Length)
            {
                throw new IndexOutOfRangeException();
            }
            _pets[index] = newPetInfo;
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, _pets.Select(pet => pet.ToString()));
        }
    }
}