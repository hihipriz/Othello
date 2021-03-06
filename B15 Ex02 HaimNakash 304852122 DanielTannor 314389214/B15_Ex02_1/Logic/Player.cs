﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Player.cs" company="">
//   
// </copyright>
// <summary>
//   The player.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace B15_Ex02_1.Logic
{
    using B15_Ex02_1.Control;

    /// <summary>
    /// The player.
    /// </summary>
    public class Player
    {
        /// <summary>
        /// The m_ player name.
        /// </summary>
        private readonly string m_PlayerName;

        /// <summary>
        /// The m player.
        /// </summary>
        private ePlayer m_Player;

        /*
         * Player points
         */
        private int m_PlayerPoints;
        private int m_PlayerGamePoints;

        /*
         * Initializes the player: name, points, type
         */
        public Player(string io_PlayerName, ePlayer io_Player)
        {
            this.m_PlayerName = io_PlayerName;
            this.m_PlayerPoints = 2;
            this.m_Player = io_Player;
        }

        /*
         * Get/Set #player points
         */
        public int PlayerPoints
        {
            get
            {
                return this.m_PlayerPoints;
            }

            set
            {
                this.m_PlayerPoints = value;
            }
        }

        public int PlayerGamePoints
        {
            get
            {
                return this.m_PlayerGamePoints;
            }

            set
            {
                this.m_PlayerGamePoints = value;
            }
        }


        /*
         * Get player type
         */
        public ePlayer Type
        {
            get
            {
                return this.m_Player;
            }

            set { this.m_Player = value; }
        }

        /*
         * Get player name
         */
        public string PlayerName
        {
            get
            {
                return this.m_PlayerName;
            }
        }

        /*
         * Updates players points
         */

        /*
         * Update player points
         */
        public void UpdatePlayerPoints(int io_PlayerPoints)
        {
            this.m_PlayerPoints += io_PlayerPoints;
        }
    }
}