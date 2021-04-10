using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenotypeDataProcessing.Structure
{
    /// <summary>
    /// Structure's parameter set
    /// </summary>
    [Serializable]
    public struct StructureParamSetStruct
    {
        /// <summary>
        /// length of burnin period
        /// </summary>
        public int burnin;
        /// <summary>
        /// number of MCMC reps after burnin
        /// </summary>
        public int numReps;
        /// <summary>
        /// data are in correct phase (relevant for linkage model only)
        /// </summary>
        public bool phased;
        /// <summary>
        /// the phase info follows a Markov model
        /// </summary>
        public bool markovPhase;
        /// <summary>
        /// use no admixture model (0=admixture model, 1=no-admix)
        /// </summary>
        public bool noAdmix;
        /// <summary>
        /// use location information to improve weak data
        /// </summary>
        public bool locPrior;
        /// <summary>
        /// use the linkage model model 
        /// </summary>
        public bool linkage;
        /// <summary>
        /// log10 of minimum allowed value of r under linkage model
        /// </summary>
        public double logRMin;
        /// <summary>
        /// log10 of maximum allowed value of r
        /// </summary>
        public double logRMax;
        /// <summary>
        /// standard deviation of log r in update
        /// </summary>
        public double logRPropSD;
        /// <summary>
        /// initial value of log10 r
        /// </summary>
        public double logRStart;
        /// <summary>
        /// use prior population information to pre-assign individuals to clusters
        /// </summary>
        public bool usePopInfo;
        /// <summary>
        /// for use when inferring whether an individual is an immigrant, or has an immigrant ancestor in the past GENSBACK generations
        /// </summary>
        public int gensBack;
        /// <summary>
        /// prior prob that an individual is a migrant (used only when USEPOPINFO==1), this should be small, eg 0.01 or 0.1.
        /// </summary>
        public double migPrior;
        /// <summary>
        /// dirichlet parameter for degree of admixture 
        /// </summary>
        public double alpha;
        /// <summary>
        /// infer ALPHA (the admixture parameter)
        /// </summary>
        public bool inferAlpha;
        /// <summary>
        /// individual alpha for each population
        /// </summary>
        public bool popAlphas;
        /// <summary>
        /// use a uniform prior for alpha
        /// </summary>
        public bool unifPriorAlphas;
        /// <summary>
        /// max value of alpha if uniform prior
        /// </summary>
        public double alphaMax;
        /// <summary>
        /// 
        /// </summary>
        public double alphaPropSD;
        /// <summary>
        /// 
        /// </summary>
        public double alphaPriorA;
        /// <summary>
        /// 
        /// </summary>
        public double alphaPriorB;
        /// <summary>
        /// allele frequencies are correlated among pops
        /// </summary>
        public bool freqsCorr;
        /// <summary>
        /// assume same value of Fst for all subpopulations
        /// </summary>
        public bool oneFst;
        /// <summary>
        /// prior mean and SD of Fst for pops
        /// </summary>
        public double priorMean;
        /// <summary>
        /// the prior is a Gamma distribution with these parameters
        /// </summary>
        public double priorSD;
        /// <summary>
        /// dirichlet parameter for allele frequencies 
        /// </summary>
        public double lambda;
        /// <summary>
        /// infer LAMBDA (the allele frequencies parameter)
        /// </summary>
        public bool inferLambda;
        /// <summary>
        /// nfer a separate lambda for each pop
        /// </summary>
        public bool popSpecifiLambda;
        /// <summary>
        /// estimate the probability of the data under the model, used when choosing the best number of subpopulations
        /// </summary>
        public bool computePorb;
        /// <summary>
        /// collect data about the distribution of ancestry coefficients(Q) for each individual
        /// </summary>
        public bool ancestDist;
        /// <summary>
        /// the distribution of Q values is stored as a histogram with this number of boxes
        /// </summary>
        public int numboxes;
        /// <summary>
        /// the size of the displayed probability interval on Q(values between 0.0--1.0)
        /// </summary>
        public double ancestPint;
        /// <summary>
        /// use given populations as the initial condition for population origins
        /// </summary>
        public bool startPopInfo;
        /// <summary>
        /// frequency of using Metropolis step to update Q under admixture model
        /// </summary>
        public int metroFreq;
        /// <summary>
        /// Q-hat printed to a separate file
        /// </summary>
        public bool printQHat;
    }
}
