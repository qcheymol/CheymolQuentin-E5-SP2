-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Hôte : localhost:3306
-- Généré le : Dim 21 mai 2023 à 18:41
-- Version du serveur :  5.7.24
-- Version de PHP : 7.4.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `gsbc`
--

-- --------------------------------------------------------

--
-- Structure de la table `famille`
--

CREATE TABLE `famille` (
  `idFamille` int(11) NOT NULL,
  `libelle` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `famille`
--

INSERT INTO `famille` (`idFamille`, `libelle`) VALUES
(1, 'Adrénaline'),
(2, 'Antalgiques (palier 1)'),
(3, 'Antalgiques (palier 2)'),
(4, 'Antalgiques (palier 3)'),
(5, 'Antiagrégants plaquettaires'),
(6, 'Antibiotiques'),
(7, 'Antidépresseurs'),
(8, 'Antidiabétiques oraux'),
(9, 'Antiémétiques'),
(10, 'Anti-inflammatoires non stéroïdiens (AINS)'),
(11, 'Anti-inflammatoires stéroïdiens'),
(12, 'Antiparkinsoniens'),
(13, 'Antispasmodiques'),
(14, 'Antiulcéreux'),
(15, 'Antivitamines K (AVK) '),
(16, 'Anxiolytiques'),
(17, 'Benzodiazépines'),
(18, 'Bêtabloquants'),
(19, 'Catécholamines'),
(20, 'Célocurine (Suxaméthonium)'),
(21, 'Corticoïdes'),
(22, 'Cristalloïdes '),
(23, 'Digitaliques'),
(24, 'Diprivan (propofol)'),
(25, 'Diurétiques'),
(26, 'Fibrinolytiques'),
(27, 'Fluidifiants bronchiques'),
(28, 'Héparines de bas poids moléculaire  (HBPM)'),
(29, 'Héparines non fractionnées (HNF) '),
(30, 'Hypnotiques'),
(31, 'Hypnovel (Midazolam)'),
(32, 'Inhibiteurs de l\'enzyme de conversion (IEC)'),
(33, 'Laxatifs'),
(34, 'Neuroleptiques'),
(35, 'Noradrénaline'),
(36, 'Thrombolytiques');

-- --------------------------------------------------------

--
-- Structure de la table `medecin`
--

CREATE TABLE `medecin` (
  `idMedecin` int(11) NOT NULL,
  `nom` varchar(30) DEFAULT NULL,
  `prenom` varchar(30) DEFAULT NULL,
  `adresse` varchar(50) DEFAULT NULL,
  `tel` varchar(10) DEFAULT NULL,
  `departement` varchar(5) DEFAULT NULL,
  `idSpecialite` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `medecin`
--

INSERT INTO `medecin` (`idMedecin`, `nom`, `prenom`, `adresse`, `tel`, `departement`, `idSpecialite`) VALUES
(1, 'Pierre-Emmanuel', 'Parot', '6 av Berry, GOUZON', '0555622124', '27', 41),
(2, 'Harel', 'Matthieu', '4 quai Henri Bugnet , BESANCON', '0381831325', '25', 32),
(3, 'Maire', 'Maryse', '98 bd Alliés VESOUL', '0384752005', '70', 41),
(4, 'Borel', 'Michaël', '6 r Ordener, PARIS', '0146335250', '75', 10),
(5, 'Pezerat', 'Raphaël', '18r Baraban, LYON', '0478245826', '69', 52),
(6, 'Lejeune', 'Laurent', '24 av Tarente, BREST', '0298038562', '29', 38),
(7, 'Proux', 'Sébastien', '127r Mondenard, BORDEAUX', '0556792845', '33', 4),
(8, 'Gaumart', 'Emmanuelle', '73 r Fontaines, TOULOUSE', '0561499090', '31', 17),
(9, 'Coustaud', 'Thierry', 'bât C 70 av William Booth, MARSEILLE', '0491453418', '13', 49);

-- --------------------------------------------------------

--
-- Structure de la table `medicament`
--

CREATE TABLE `medicament` (
  `idMedicament` int(11) NOT NULL,
  `nomCommercial` varchar(30) DEFAULT NULL,
  `composition` varchar(1000) DEFAULT NULL,
  `effets` varchar(1000) DEFAULT NULL,
  `contreIndications` varchar(1000) DEFAULT NULL,
  `idFamille` int(11) NOT NULL,
  `PrixUnitaire` int(11) NOT NULL DEFAULT '2'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `medicament`
--

INSERT INTO `medicament` (`idMedicament`, `nomCommercial`, `composition`, `effets`, `contreIndications`, `idFamille`, `PrixUnitaire`) VALUES
(1, 'Alphacaine', 'articaïne (chlorhydrate d\')  72 mg\r\nadrénaline (chlorhydrate d\')  0,0108 mg', 'Anesthésie locale ou loco-régionale en pratique odonto-stomatologique.', 'Hypersensibilité articaïne\r\nHypersensibilité anesthésiques locaux de type amide\r\nHypersensibilité adrénaline\r\nHypersensibilité sodium métabisulfite\r\nEpilepsie non contrôlée\r\nEnfant de moins de 4 ans\r\nEnfant de moins de 20 kg', 1, 6),
(2, 'EPIPEN', 'adrénaline  1 mg', 'Traitement d\'urgence d\'intenses réactions allergiques', 'Il n\'y a pas de contre-indication ', 1, 2),
(3, 'Daflgan', 'paracétamol  500 mg', 'Traitement symptomatique des douleurs d\'intensité légère à modérée et/ou des états fébriles.', 'Insuffisance hépatocellulaire sévère ou maladie active du foie décompensée', 2, 2),
(4, 'Doliprane', 'Paracétamol 1000 mg', 'Traitement symptomatique des douleurs d\'intensité légère à modérée et/ou des états fébriles.\r\n\r\nTraitement symptomatique des douleurs de l’arthrose.', 'Hypersensibilité à la substance active ou à l’un des excipients mentionnés à la rubrique 6.1.\r\n\r\n· Insuffisance hépatocellulaire sévère.\r\n\r\n· Enfant de moins de 6 ans en raison des risques de fausse route.', 2, 2),
(5, 'Dafalgan codéine', 'paracétamol  500 mg\r\ncodéine (phosphate de) hémihydraté  30 mg', 'traitement des douleurs aiguës d’intensité modérée qui ne peuvent pas être soulagées par d’autres antalgiques comme le paracétamol ou l’ibuprofène ', 'Enfant de moins de 12 ans.\r\nHypersensibilité à l’un des excipients ', 3, 2),
(6, 'Lindilane', 'codéine  18,40 mg\r\nhémihydraté   25 mg\r\nparacétamol  400 mg', 'traitement des douleurs aiguës d’intensité modérée qui ne peuvent pas être soulagées par d’autres antalgiques comme le paracétamol ou l’ibuprofène ', 'Enfant de moins de 18 ans.\r\nHypersensibilité à l’un des excipients ', 3, 2),
(7, 'Sévrédol', 'insuffisance respiratoire grave \r\ninsuffisance hépatique grave\r\népilpesie non stabilisée par un traitement\r\nen association avec les antalgiques contenant de la buprénorphine, de la nalbuphine ou de la pentazocine \r\nenfant de moins de 6 ans', 'combat la douleur en agissant directement sur le cerveau.', 'Morphine sulfate 10 mg', 3, 2),
(8, 'Moscontin', 'Morphine sulfate 10 mg', 'contre les douleurs intenses ou rebelles aux antalgiques de niveau plus faible.', 'hypersensibilité à la substance active ou à l’un des excipients\r\nenfant de moins de 6 ans (car la prise de comprimés nécessite la maîtrise du carrefour oro-pharyngé)\r\ninsuffisance respiratoire décompensée (en l’absence de ventilation artificielle)\r\ninsuffisance hépatocellulaire sévère (avec encéphalopathie)', 4, 2),
(9, 'PROZAC', 'Fluoxétine 20mg\r\nSaccharose 3g', 'traitement d\'états dépressifs ', 'antécédent d\'allergie à la fluoxétine\r\nen association avec les IMAO non sélectifs et les médicaments contenant du métoprolol utilisés dans l\'insuffisance cardiaque', 7, 2),
(10, 'CITALOPRAM ALTER', 'Citalopram 20 mg', 'Dépression de l’adulte\r\nTroubles paniques', 'insuffisance rénale grave\r\nanomalie de l\'électrocardiogramme favorisant les torsades de pointes', 7, 2),
(11, 'Artex', 'allergies', 'traitement Hypertension artérielle', 'Tertatolol chlorhydrate \r\n5 mg', 13, 2),
(12, 'AlMa', 'Terpine 2 mg', 'Traitement d\'appoint des troubles de la sécrétion bronchique.', 'Hypersensibilité terpine\r\nAllaitement\r\nGrossesse\r\nDéficit en lactase', 19, 2);

-- --------------------------------------------------------

--
-- Structure de la table `offrir`
--

CREATE TABLE `offrir` (
  `idRapport` int(11) NOT NULL,
  `idMedicament` int(11) NOT NULL,
  `quantite` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `offrir`
--

INSERT INTO `offrir` (`idRapport`, `idMedicament`, `quantite`) VALUES
(1, 1, 4),
(1, 4, 6);

-- --------------------------------------------------------

--
-- Structure de la table `rapport`
--

CREATE TABLE `rapport` (
  `idRapport` int(11) NOT NULL,
  `date` datetime DEFAULT NULL,
  `motif` varchar(50) DEFAULT NULL,
  `bilan` varchar(250) DEFAULT NULL,
  `idVisiteur` int(11) NOT NULL,
  `idMedecin` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `rapport`
--

INSERT INTO `rapport` (`idRapport`, `date`, `motif`, `bilan`, `idVisiteur`, `idMedecin`) VALUES
(1, '2023-05-02 13:29:20', 'Rendez-Vous', 'Rien à signaler', 2, 9),
(2, '2023-05-21 00:00:00', 'Visite contractuel', 'Nouveau Médicament', 6, 6);

-- --------------------------------------------------------

--
-- Structure de la table `specialite`
--

CREATE TABLE `specialite` (
  `idSpecialite` int(11) NOT NULL,
  `libelle` varchar(150) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `specialite`
--

INSERT INTO `specialite` (`idSpecialite`, `libelle`) VALUES
(1, 'L\'allergologie.'),
(2, 'L\'andrologie.'),
(3, 'L\'anesthésiologie.'),
(4, 'La cardiologie.'),
(5, 'La chirurgie.'),
(6, 'La chirurgie cardiaque.'),
(7, 'La chirurgie plastique, reconstructive et esthétique.'),
(8, 'La chirurgie générale.'),
(9, 'La chirurgie gynécologique.'),
(10, 'La chirurgie maxillo-faciale.'),
(11, 'La chirurgie oculaire.'),
(12, 'La chirurgie orale.'),
(13, 'La chirurgie pédiatrique.'),
(14, 'La chirurgie thoracique.'),
(15, 'La chirurgie vasculaire.'),
(16, 'La chirurgie viscérale.'),
(17, 'La neurochirurgie'),
(18, 'La dermatologie.'),
(19, 'L\'endocrinologie.'),
(20, 'La gastro-entérologie.'),
(21, 'La gériatrie.'),
(22, 'La gynécologie.'),
(23, 'L\'hématologie.'),
(24, 'L\'hépatologie.'),
(25, 'L\'immunologie.'),
(26, 'L\'infectiologie.'),
(27, 'La médecine aiguë.'),
(28, 'La médecine du travail.'),
(29, 'La médecine d\'urgence.'),
(30, 'La médecine générale.'),
(31, 'La médecine interne.'),
(32, 'La médecine nucléaire.'),
(33, 'La médecine palliative.'),
(34, 'La médecine physique et de réadaptation.'),
(35, 'La médecine préventive.'),
(36, 'La néonatologie.'),
(37, 'La néphrologie.'),
(38, 'La neurologie'),
(39, 'L\'obstétrique.'),
(40, 'L\'odontologie.'),
(41, 'L\'oncologie.'),
(42, 'L\'ophtalmologie.'),
(43, 'L\'orthopédie.'),
(44, 'L\'otorhinolaryngologie.'),
(45, 'La pédiatrie.'),
(46, 'La pneumologie.'),
(47, 'La podologie.'),
(48, 'La psychiatrie.'),
(49, 'La radiologie.'),
(50, 'La radiothérapie.'),
(51, 'La rhumatologie.'),
(52, 'L\'urologie.');

-- --------------------------------------------------------

--
-- Structure de la table `visiteur`
--

CREATE TABLE `visiteur` (
  `idVisiteur` int(11) NOT NULL,
  `nom` varchar(30) DEFAULT NULL,
  `prenom` varchar(30) DEFAULT NULL,
  `login` varchar(50) DEFAULT NULL,
  `mdp` varchar(30) DEFAULT NULL,
  `adresse` varchar(50) DEFAULT NULL,
  `cp` int(5) DEFAULT NULL,
  `ville` varchar(30) DEFAULT NULL,
  `dateEmbauche` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `visiteur`
--

INSERT INTO `visiteur` (`idVisiteur`, `nom`, `prenom`, `login`, `mdp`, `adresse`, `cp`, `ville`, `dateEmbauche`) VALUES
(1, 'Kervarrec', 'Yann', 'KerYan', 'flptg', '19 bd Alexandre Matin', 45000, 'ORLEANS', '2006-11-30 00:00:00'),
(2, 'Corpel', 'Olivier', 'CorOli', 'vbdls', '6 av Pasteur', 10000, 'TROYES', '2010-12-29 00:00:00'),
(3, 'Bendelé', 'Didier', 'Bendid', 'qsdc', '42 r Franklin', 68200, 'MULHOUSE', '2014-02-11 00:00:00'),
(4, 'Sar', 'Sothea', 'SotSar', 'hkyjfs', '81 r St Dominique', 75000, 'PARIS', '2008-01-09 00:00:00'),
(5, 'Giraud', 'Anne-Marie', 'GirAnn', '98555', '73 bd Camille Flammarion', 13004, 'MARSEILLE', '2018-03-03 00:00:00'),
(6, 'Chapuis', 'Gérard', 'ChaGer', 'lfgt23', '97 av William Booth', 25000, 'BESANCON', '2008-06-10 00:00:00'),
(7, 'Pardon', 'Martial', 'ParMar', 'gfhghd', '2 r Lucie et Raymond Aubrac', 70000, 'VESOUL', '2011-03-05 00:00:00'),
(8, 'Choix', 'Philippe', 'ChoPhi', 'qqzttf', '17 r Carnot', 70200, 'LURE', '2007-07-07 00:00:00');

--
-- Index pour les tables déchargées
--

--
-- Index pour la table `famille`
--
ALTER TABLE `famille`
  ADD PRIMARY KEY (`idFamille`);

--
-- Index pour la table `medecin`
--
ALTER TABLE `medecin`
  ADD PRIMARY KEY (`idMedecin`),
  ADD KEY `FK_Specialite` (`idSpecialite`);

--
-- Index pour la table `medicament`
--
ALTER TABLE `medicament`
  ADD PRIMARY KEY (`idMedicament`),
  ADD KEY `FK_Famille` (`idFamille`);

--
-- Index pour la table `offrir`
--
ALTER TABLE `offrir`
  ADD PRIMARY KEY (`idMedicament`,`idRapport`),
  ADD KEY `FK_idMedicament` (`idMedicament`) USING BTREE;

--
-- Index pour la table `rapport`
--
ALTER TABLE `rapport`
  ADD PRIMARY KEY (`idRapport`),
  ADD KEY `FK_Medecin` (`idMedecin`),
  ADD KEY `FK_Visiteur` (`idVisiteur`) USING BTREE;

--
-- Index pour la table `specialite`
--
ALTER TABLE `specialite`
  ADD PRIMARY KEY (`idSpecialite`);

--
-- Index pour la table `visiteur`
--
ALTER TABLE `visiteur`
  ADD PRIMARY KEY (`idVisiteur`);

--
-- AUTO_INCREMENT pour les tables déchargées
--

--
-- AUTO_INCREMENT pour la table `famille`
--
ALTER TABLE `famille`
  MODIFY `idFamille` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=37;

--
-- AUTO_INCREMENT pour la table `medecin`
--
ALTER TABLE `medecin`
  MODIFY `idMedecin` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT pour la table `medicament`
--
ALTER TABLE `medicament`
  MODIFY `idMedicament` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT pour la table `rapport`
--
ALTER TABLE `rapport`
  MODIFY `idRapport` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT pour la table `specialite`
--
ALTER TABLE `specialite`
  MODIFY `idSpecialite` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=53;

--
-- AUTO_INCREMENT pour la table `visiteur`
--
ALTER TABLE `visiteur`
  MODIFY `idVisiteur` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `medecin`
--
ALTER TABLE `medecin`
  ADD CONSTRAINT `FK_Specialite` FOREIGN KEY (`idSpecialite`) REFERENCES `specialite` (`idSpecialite`);

--
-- Contraintes pour la table `medicament`
--
ALTER TABLE `medicament`
  ADD CONSTRAINT `FK_Famille` FOREIGN KEY (`idFamille`) REFERENCES `famille` (`idFamille`);

--
-- Contraintes pour la table `offrir`
--
ALTER TABLE `offrir`
  ADD CONSTRAINT `Fk_idMedicament` FOREIGN KEY (`idMedicament`) REFERENCES `medicament` (`idMedicament`);

--
-- Contraintes pour la table `rapport`
--
ALTER TABLE `rapport`
  ADD CONSTRAINT `FK_Medecin` FOREIGN KEY (`idMedecin`) REFERENCES `medecin` (`idMedecin`),
  ADD CONSTRAINT `FK_Visiteur` FOREIGN KEY (`idVisiteur`) REFERENCES `visiteur` (`idVisiteur`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
