﻿namespace Domain.Util
{
    public static class Phrase
    {
        private static readonly string[] Phrases = new[]
        {
            "Seja muito bem vindo",
            "Bem-vindo ao nosso mundo!",
            "É um prazer recebê-lo!",
            "Que bom tê-lo conosco!",
            "Estamos felizes por vê-lo aqui!",
            "Seja bem-vindo, caro visitante!",
            "Bem-vindo ao nosso espaço!",
            "Você é muito bem-vindo!",
            "Estamos contentes com sua presença!",
            "Dê uma olhada ao redor e divirta-se!",
            "É uma alegria tê-lo entre nós!",
            "Bem-vindo à família!",
            "É uma honra recebê-lo!",
            "Você é parte importante da nossa comunidade!",
            "Seja bem-vindo à nossa casa virtual!",
            "Agradecemos por nos escolher!",
            "Você chegou ao lugar certo!",
            "Esperamos que se sinta em casa!",
            "Bem-vindo ao nosso universo!",
            "Estamos animados por tê-lo aqui!",
            "Aqui começa uma grande jornada!",
            "Você faz parte da nossa história!",
            "Seja bem-vindo ao nosso cantinho!",
            "Estamos de braços abertos para recebê-lo!",
            "Bem-vindo à nossa família online!",
            "Estamos ansiosos para compartilhar momentos incríveis com você!",
            "Que bom que você está aqui!",
            "Bem-vindo à nossa comunidade!",
            "Sinta-se em casa!",
            "Bem-vindo ao nosso mundo virtual!",
            "A porta está sempre aberta para você!",
            "Bem-vindo ao início de uma bela jornada!",
            "Estamos empolgados para começar!",
            "Agradecemos por fazer parte da nossa história!",
            "Seja bem-vindo à aventura!",
            "Sua visita é muito especial para nós!",
            "Estamos felizes por tê-lo como parte da nossa equipe!",
            "Bem-vindo ao lugar onde os sonhos se tornam realidade!",
            "Aqui começa uma nova etapa!",
            "Que a sua estadia seja memorável!",
            "Estamos aqui para tornar sua experiência incrível!",
            "Bem-vindo ao nosso lar digital!",
            "É um prazer conhecê-lo!",
            "Estamos prontos para começar!",
            "Bem-vindo à nossa jornada!",
            "Estamos ansiosos para descobrir grandes coisas juntos!",
            "Aqui, você é mais do que bem-vindo!",
            "Seja bem-vindo, amigo!",
            "Bem-vindo ao futuro!",
            "Estamos aqui para recebê-lo com os braços abertos!",
            "Bem-vindo à nossa comunidade online!",
            "Agora, você faz parte da nossa família!",
            "Estamos entusiasmados por começar esta jornada com você!",
            "Bem-vindo ao nosso espaço digital!",
            "Bem-vindo ao nosso círculo de amigos!",
            "Seja bem-vindo ao nosso mundo mágico!",
            "Estamos aqui para guiá-lo a cada passo do caminho!",
            "Bem-vindo à era digital!",
            "Sua presença é uma honra para nós!",
            "Estamos prontos para fazer grandes coisas juntos!",
            "Bem-vindo ao seu novo lar online!",
            "Aqui, a diversão nunca termina!",
            "Estamos felizes em compartilhar este momento com você!",
            "Seja bem-vindo à nossa festa virtual!",
            "Bem-vindo ao nosso playground digital!",
            "Aqui, cada dia é uma nova aventura!",
            "Estamos animados para começar esta jornada!",
            "Bem-vindo ao lugar onde os sonhos se realizam!",
            "Sua presença é o nosso maior presente!",
            "Bem-vindo à nossa incrível comunidade!",
            "Estamos ansiosos para descobrir o que o futuro reserva!",
            "Bem-vindo à revolução digital!",
            "Seja bem-vindo, explorador!",
            "Estamos prontos para embarcar nesta jornada com você!",
            "Bem-vindo ao nosso mundo de maravilhas!",
            "Aqui, a aventura começa!",
            "Estamos prontos para criar memórias inesquecíveis juntos!",
            "Bem-vindo à sua nova casa na web!",
            "Seja bem-vindo ao nosso ninho virtual!",
            "Estamos prontos para fazer grandes coisas juntos!",
            "Bem-vindo ao nosso universo digital!",
            "Aqui, cada momento é único!",
            "Estamos ansiosos para criar momentos memoráveis ​​com você!",
            "Bem-vindo ao nosso oásis digital!",
            "Seja bem-vindo ao nosso playground virtual!",
            "Estamos prontos para começar esta jornada épica!",
            "Bem-vindo ao nosso mundo de possibilidades infinitas!",
            "Aqui, você é a estrela!",
            "Estamos ansiosos para conhecer você melhor!",
            "Bem-vindo ao nosso santuário virtual!",
            "Seja bem-vindo à nossa família online!",
            "Estamos animados para começar esta nova aventura!",
            "Bem-vindo ao nosso mundo de maravilhas digitais!",
            "Aqui, a diversão nunca termina!",
            "Estamos prontos para construir memórias incríveis com você!",
            "Bem-vindo ao nosso lar digital!",
            "Seja bem-vindo ao nosso universo cibernético!",
            "Estamos prontos para fazer história juntos!",
            "Bem-vindo ao lugar onde os sonhos se tornam realidade!",
            "Aqui, a imaginação não tem limites!",
            "Estamos ansiosos para ver o que o futuro nos reserva!",
            "Bem-vindo ao nosso mundo de possibilidades!",
            "Seja bem-vindo ao nosso incrível universo virtual!",
            "Estamos animados para embarcar nesta jornada com você!",
            "Bem-vindo ao nosso reino digital!",
            "Aqui, você é a estrela do show!",
            "Estamos prontos para criar algo especial juntos!",
            "Bem-vindo à nossa comunidade virtual!",
            "Seja bem-vindo ao nosso playground digital!",
            "Estamos ansiosos para começar esta jornada emocionante!",
            "Bem-vindo ao nosso mundo onde tudo é possível!",
            "Aqui, você é parte da família!",
            "Estamos prontos para fazer coisas incríveis juntos!",
            "Bem-vindo à nossa arena digital!",
            "Seja bem-vindo ao nosso incrível mundo online!",
            "Estamos animados para começar esta aventura com você!"
        };

        public static string GetRandomWelcomeMessage()
        {
            var randomGenerator = new Random();

            return Phrases[randomGenerator.Next(Phrases.Length)];
        }
    }
}
