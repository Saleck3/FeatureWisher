<?php

namespace App\Controller;

use Symfony\Bundle\FrameworkBundle\Controller\AbstractController;
use Symfony\Component\HttpFoundation\Response;
use Symfony\Component\Routing\Annotation\Route;

class MiscPages extends AbstractController
{
    /**
     * @Route("/", name="app_home")
     * @return Response
     */
    public function homePage(): Response
    {
        return $this->render("home.html.twig");

    }

}